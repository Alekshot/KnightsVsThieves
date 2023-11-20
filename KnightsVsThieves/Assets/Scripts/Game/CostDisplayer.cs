using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CostDisplayer : MonoBehaviour
{
    public int towerID;
    public int towerCost;

    void Start()
    {
        towerCost = GameManager.instance.spawner.TowerCost(towerID);
        GetComponent<TMPro.TextMeshProUGUI>().text = towerCost.ToString();
    }
}
