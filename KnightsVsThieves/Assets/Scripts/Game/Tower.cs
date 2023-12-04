using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public int health;
    public int cost;

    protected virtual void Start()
    {
        Debug.Log("BASE TOWER");
    }

    public virtual bool LoseHealth(int amount)
    {
        health -= amount;

        if (health <= 0)
        {
            Die();
            return true;
        }
        return false;
    }

    protected virtual void Die()
    {
        Debug.Log("Tower is dead");
        Destroy(gameObject);
    }
}
