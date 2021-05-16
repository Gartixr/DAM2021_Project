using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUp : MonoBehaviour
{
    public int health = 20;
    void OnTriggerEnter2D(Collider2D colInfo)
    {
        PlayerStats playerStats = (PlayerStats)colInfo.GetComponent("PlayerStats");
        if (playerStats)
        { 
            playerStats.SetCurHealth(playerStats.GetCurHealth() + health);
            playerStats.CountHealthCup = ++playerStats.CountHealthCup;
            Destroy(gameObject);
        }
    }
}
