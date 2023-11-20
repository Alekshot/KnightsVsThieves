using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_Tower : MonoBehaviour
{
    public int health;
    public int damage;
    public GameObject prefab_shootItem;
    public float interval;
    public int cost;

    void Start()
    {
        StartCoroutine(ShootDelay());
    }

    IEnumerator ShootDelay()
    {
        yield return new WaitForSeconds(interval);
        ShootItem();
        StartCoroutine(ShootDelay());
    }

    void ShootItem()
    {
        GameObject shotItem = Instantiate(prefab_shootItem, transform);
        shotItem.GetComponent<ShootItem>().Init(damage);
    }

    public void LoseHealth()
    {
        health--;

        if (health <= 0)
            Die();
    }

    public void Die()
    {
        Debug.Log("Tower is dead");
        Destroy(gameObject);
    }
}
