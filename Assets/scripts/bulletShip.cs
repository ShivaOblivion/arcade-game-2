using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletShip : MonoBehaviour
{
    private Vector2 moveDirection;
    private float movSpeed;

    private void OnEnable()
    {
        Invoke("Destroy",3f);
    }

    private void Start()
    {
        movSpeed = 5f;
    }

    private void Update()
    {
        transform.Translate(moveDirection*movSpeed*Time.deltaTime);
    }

    public void SetMovDirection(Vector2 dir)
    {
        moveDirection = dir;
        
    }

    private void Destroy()
    {
        gameObject.SetActive(false);
            
    }

    private void OnDisable()
    {
        CancelInvoke();
    }
}
    
