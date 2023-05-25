using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    GameObject MyChar;

    // Start is called before the first frame update
    void Start()
    {
        this.MyChar = GameObject.Find("MyChar");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.1f, 0, 0);

        if (transform.position.x < -9.0f)
        {
            Destroy(gameObject);
        }

        Vector2 m1 = transform.position;
        Vector2 m2 = this.MyChar.transform.transform.position;
        Vector2 dir = m1 - m2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;

        if (d < r1 + r2)
        {
            Destroy(gameObject);
        }

    }

}
