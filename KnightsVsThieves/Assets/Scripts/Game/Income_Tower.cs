using System.Collections;
using UnityEngine;

public class Income_Tower : MonoBehaviour
{
    public int health;
    public int incomeValue;
    public float interval;
    public GameObject obj_coin;
    public int cost;

    void Start()
    {
        Debug.Log("PINK");
        StartCoroutine(Interval());
    }

    IEnumerator Interval()
    {
        yield return new WaitForSeconds(interval);
        IncreaseIncome();
        StartCoroutine(Interval());
    }

    public void IncreaseIncome()
    {
        GameManager.instance.currency.Gain(incomeValue);
        StartCoroutine(CoinIndication());
    }

    IEnumerator CoinIndication()
    {
        obj_coin.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        obj_coin.SetActive(false);
    }

    public void LoseHealth()
    {
        health--;

        if(health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Debug.Log("Tower is dead");
        Destroy(gameObject);
    }
}
