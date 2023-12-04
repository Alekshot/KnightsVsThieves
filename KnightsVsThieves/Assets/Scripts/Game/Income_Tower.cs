using System.Collections;
using UnityEngine;

public class Income_Tower : Tower
{
    public int incomeValue;
    public float interval;
    public GameObject obj_coin;

    protected override void Start()
    {
        Debug.Log("INCOME");
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
}
