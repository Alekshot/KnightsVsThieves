using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_Tower : Tower
{
    public int damage;
    public GameObject prefab_shootItem;
    public float interval;

    protected override void Start()
    {
        Debug.Log("ATTACK");
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
}
