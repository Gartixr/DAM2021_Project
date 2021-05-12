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
        movement.Normalize();

    }

    void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + movement * playerStats.GetSpeed() * Time.fixedDeltaTime);
    }

    public IEnumerator Knockback(float knockbackDuration, float KnockbackPower, Transform obj)
    {
        float timer = 0;
        while (knockbackDuration > timer)
        {
            timer += Time.deltaTime;
            Vector2 direction = (obj.transform.position - this.transform.position).normalized;
            rb2d.AddForce(-direction * KnockbackPower);

            yield return 0;
        }
    }
}
