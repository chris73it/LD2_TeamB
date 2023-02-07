using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/CoinPouch", order = 3)]
public class Coins : ScriptableObject
{
    [SerializeField]
    private int coins;

    public void Add(int amount)
    {
        coins += amount;
    }

    public void Subtract(int amount)
    {
        coins -= amount;
    }

    public void Set(int amount)
    {
        coins = amount;
    }

    public int Get()
    {
        return coins;
    }
}
