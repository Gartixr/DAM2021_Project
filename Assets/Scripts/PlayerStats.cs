using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int maxHealth = 100;
    public int curHealth;
    public float speed = 6.5f;
    public float damage;

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
