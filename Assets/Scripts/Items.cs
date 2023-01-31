using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/ItemInventory", order = 1)]
public class Items : ScriptableObject
{
    List<Item> items;

    public void addItem(Item newItem)
    {
        items.Add(newItem);
    }

    public void removeItem(Item remItem)
    {
        items.Remove(remItem);
    }
}
