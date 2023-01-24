using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField]
    Items inv;

    [SerializeField]
    Troops barracks;

    public int coins;

    void Start()
    {
        coins = 0;
    }
}
