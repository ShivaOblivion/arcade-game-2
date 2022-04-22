using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipMoc : MonoBehaviour
{
    private float movspeed;
    private bool movRight;

    void Start()
    {
        movspeed = 2f;
        movRight = true;
    }


    void Update()
    {
        if (transform.position.x > 7f)
        {
            movRight = false;

        }
        else if (transform.position.x < -7f)
        {
            movRight = true;
        }

        if (movRight)
        {
            transform.position =new Vector2(transform.position.x + movspeed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - movspeed * Time.deltaTime, transform.position.y);
        }
    }
}