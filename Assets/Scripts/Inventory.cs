using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Items inv;
    public Troops barracks;
    public Coins coins;

    void Start()
    {
        coins.Set(0);
    }
}
