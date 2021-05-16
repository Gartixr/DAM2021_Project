using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerStats playerStats;
    public int fallBoundary = -20;
    public MenuDeath menuDeath;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= fallBoundary)
        {
            DamagePlayer(99999999);
        }
    }

    public void DamagePlayer(int damage)
    {
        playerStats.curHealth -= damage;
        if (playerStats.curHealth <= 0)
        {
            Destroy(gameObject);
            menuDeath.gameObject.SetActive(true);
        }
    }
    
}
