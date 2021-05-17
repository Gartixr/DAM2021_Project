using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public int damage = 20;
    public GameObject deathEffect;
    public float knockbackDuration = 1; 
    public float knockbackPower = 100;
    public PlayerStats playerStats;
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
        playerStats.countEnemyKilled = ++playerStats.countEnemyKilled;
        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D colInfo)
    {
        Debug.Log("A");
        Player _player = colInfo.collider.GetComponent<Player>();
        PlayerMovement playerMovement = colInfo.collider.GetComponent<PlayerMovement>();
        if (_player)
        {
            StartCoroutine(playerMovement.Knockback(knockbackDuration, knockbackPower, this.transform));
            _player.DamagePlayer(damage);
        }
    }
}
