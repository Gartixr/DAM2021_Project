using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageUp : MonoBehaviour
{
    public float damage = 20;
    void OnTriggerEnter2D(Collider2D colInfo)
    {
        PlayerStats playerStats = (PlayerStats)colInfo.GetComponent("PlayerStats");
        if (playerStats)
        { 
            playerStats.SetDamage(playerStats.GetDamage() + damage);
            Destroy(gameObject);
        }
    }
}
