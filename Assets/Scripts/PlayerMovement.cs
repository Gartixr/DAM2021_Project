using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D rb2d;
    public PlayerStats playerStats;
    public Vector2 movement;
    private Boolean m_facingRight;
    
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // if (movement.x > 0 && m_facingRight)
        // {
        //     Flip();
        // }
        // else if(movement.x < 0 && !m_facingRight)
        // {
        //     Flip();
        // } 

    }

    void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + movement * playerStats.GetSpeed() * Time.fixedDeltaTime);
    }

    private void Flip()
    {
        m_facingRight = !m_facingRight;
        transform.Rotate(0f, 180f, 0f);
    }
}
