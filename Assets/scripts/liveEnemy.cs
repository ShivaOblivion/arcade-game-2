using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class liveEnemy : MonoBehaviour
{
    public int live = 1;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bulletPlayer")
        {

            live = -1;
            if (live<=0)
            {
                gameObject.SetActive(false);
                
            }
        }
        

        
        
    }
    
}
