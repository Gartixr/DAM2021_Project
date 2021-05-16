using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    public float speed = 20;
    void OnTriggerEnter2D(Collider2D colInfo)
    {
        PlayerStats playerStats = (PlayerStats)colInfo.GetComponent("PlayerStats");
        if (playerStats)
        { 
            playerStats.SetSpeed(playerStats.GetSpeed() + speed);
            playerStats.CountSpeedCup = ++playerStats.CountSpeedCup;
            Destroy(gameObject);
        }
    }
}
