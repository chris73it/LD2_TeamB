using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/ItemInventory", order = 1)]
public class Items : ScriptableObject
{
    List<Item> items;

    void addItem(Item newItem)
    {
        items.Add(newItem);
    }

    void removeItem(Item remItem)
    {
        items.Remove(remItem);
    }
}
