using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerShoot : MonoBehaviour
{
    [SerializeField] private Transform reticlule;
    [SerializeField] private GameObject bullet;
   [SerializeField] private bool playershoot;
    private int inShoot;
    private void Start()
    {
        playershoot = false;
    }

    public void Update()
    { if (playershoot == true)
        {
            playershoot = false;
            var instantiatedBullet = Instantiate(bullet, transform.position, Quaternion.identity);
            Debug.Log("shoot");

        }

        if ( inShoot>=10)
        {
            playershoot = true;
            inShoot = 0;
            Debug.Log("+1");

        }else
        {
            inShoot++;

        }
    }
    }
       

    
