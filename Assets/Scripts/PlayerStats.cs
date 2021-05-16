using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int maxHealth = 100;
    public int curHealth;
    public float speed = 6.5f;
    public float damage;
    public int countHealthCup = 0;
    public int countSpeedCup = 0;
    public int countDamageCup = 0;
    public int countEnemyKilled = 0;

    public int CountHealthCup
    {
        get => countHealthCup;
        set => countHealthCup = value;
    }

    public int CountSpeedCup
    {
        get => countSpeedCup;
        set => countSpeedCup = value;
    }

    public int CountDamageCup
    {
        get => countDamageCup;
        set => countDamageCup = value;
    }

    public int CountEnemyKilled
    {
        get => countEnemyKilled;
        set => countEnemyKilled = value;
    }

    public void Init()
    {
        curHealth = maxHealth;
    }
    public int GetCurHealth()
    {
        return this.curHealth;
    }
    public float GetSpeed()
    {
        return this.speed;
    }
    public float GetDamage()
    {
        return this.damage;
    }
    public void SetCurHealth(int health)
    {
        this.curHealth = Mathf.Clamp(health, 0, maxHealth);
    }
    public void SetSpeed(float speed)
    {
        this.speed = speed;
    }
    public void SetDamage(float damage)
    {
        this.damage = damage;
    }

}
