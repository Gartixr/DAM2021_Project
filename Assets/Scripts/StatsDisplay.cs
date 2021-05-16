using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class StatsDisplay : MonoBehaviour
{
    public PlayerStats playerStats;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI speedText;
    public TextMeshProUGUI damageText;
    void Update()
    {
        healthText.text = "Health : " + playerStats.curHealth;
        speedText.text = "Speed : " + playerStats.speed;
        damageText.text = "Damage : " + playerStats.damage;
    }
}
