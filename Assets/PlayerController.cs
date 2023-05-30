using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
 
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            transform.Translate(-0.15f,0,0);
            
            if (transform.position.y >= 4.8)
            {
                transform.Translate(0.15f, 0, 0);
            }
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.Translate(0.15f, 0, 0);

            if (transform.position.y <= -4.5)
            {
                transform.Translate(-0.15f, 0, 0);
            }
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(0, 0.15f, 0);

            if (transform.position.x >= 8.5)
            {
                transform.Translate(0,-0.15f, 0);
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Translate(0,-0.15f, 0);

            if (transform.position.x <= -8.5)
            {
                transform.Translate(0,0.15f, 0);
            }
        }

    }
}
