using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    Animator anm;
    Rigidbody2D rb;
    Vector2 Vector2;

    void Start()
    {
        Application.targetFrameRate = 60;
        anm = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2.y = Input.GetAxisRaw("Horizontal");
        Vector2.x = Input.GetAxisRaw("Vertical") * -1;
        rb.transform.Translate(Vector2.normalized / 5 ) ;

        float y = Input.GetAxisRaw("Vertical");

        if (y == 0)
        {
            anm.Play("MyChar");
        }
        else if (y == -1)
        {
            anm.Play("PlayerR");
        }
        else
        {
            anm.Play("PlayerL");
        }

    }
}
