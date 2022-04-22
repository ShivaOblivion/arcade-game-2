using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
         if (collision.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
            
             
            Debug.Log( " Destroy");
            
        }

        else if (collision.gameObject.tag=="wall")
        {
            Destroy(gameObject);
            Debug.Log( " Destroy");
        }
        

    }
}