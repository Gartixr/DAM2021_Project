using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public int damage = 20;
    public GameObject deathEffect;
    public PlayerMovement playerMovement;
    public float knockbackDuration = 1; 
    public float knockbackPower = 100;
    
    // Start is called before the first frame update

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D colInfo)
    {
        Player _player = colInfo.collider.GetComponent<Player>();
        if (_player)
        {
            _player.DamagePlayer(damage);
            StartCoroutine(playerMovement.Knockback(knockbackDuration, knockbackPower, this.transform));
        }
    }
}
