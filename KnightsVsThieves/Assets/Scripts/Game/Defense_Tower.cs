using System.Collections;
using UnityEngine;

public class Defense_Tower : MonoBehaviour
{
    public int health;
    public int cost;

    void Start()
    {

    }

    public void LoseHealth()
    {
        health--;

        if(health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Tower is dead");
        Destroy(gameObject);
    }
}
