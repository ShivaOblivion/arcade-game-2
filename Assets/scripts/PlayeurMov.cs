using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayeurMov : MonoBehaviour
{
    public float Movspeed;
    private Rigidbody2D rb;
    private float HorizontalMov;
    private float VerticalMov;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        var horizontalVelocity = HorizontalMov * Movspeed;
        var verticalVelocity =VerticalMov*Movspeed ;
        rb.velocity = new Vector2(horizontalVelocity, verticalVelocity);
    }

    public void OnHorizontal(InputValue val)
    {
        HorizontalMov = val.Get<float>();
        Debug.Log("Horizontal");
    }

    public void OnVertical(InputValue val)
    {
        VerticalMov =val.Get<float>();
        Debug.Log("Vertica");
    }
}
