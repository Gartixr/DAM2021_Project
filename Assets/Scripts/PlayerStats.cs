using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int life;
    public float speed = 6.5f;
    public float damage;
    
    public int GetLife()
    {
        return this.life;
    }
    public float GetSpeed()
    {
        return this.speed;
    }
    public float GetDamage()
    {
        return this.damage;
    }
    public void SetLife(int life)
    {
        this.life = life;
    }
    public void SetSpeed(int speed)
    {
        this.speed = speed;
    }
    public void SetDamage(int damage)
    {
        this.damage = damage;
    }

}
