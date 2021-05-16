using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    public PlayerStats playerStats;
    public TextMeshProUGUI countHealthCupResult;
    public TextMeshProUGUI countSpeedCupResult;
    public TextMeshProUGUI countDamageCupResult;
    public TextMeshProUGUI countenemyKilledResult;
    void Update()
    {
        countHealthCupResult.text =  playerStats.CountHealthCup.ToString();
        countSpeedCupResult.text = playerStats.CountSpeedCup.ToString();
        countDamageCupResult.text =  playerStats.CountDamageCup.ToString();
        countenemyKilledResult.text =  playerStats.CountEnemyKilled.ToString();
        
    }
    
}
