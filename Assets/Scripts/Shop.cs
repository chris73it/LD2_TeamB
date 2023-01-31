using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField]
    Inventory player;

    public ShopItem item1, item2, item3;

    public void Buy(ShopItem shopItem)
    {
        if (player.coins.Get() >= shopItem.item.getCost())
        {
            player.coins.Subtract(shopItem.item.getCost());
            player.inv.addItem(shopItem.item);
        }
        else
        {
            Debug.Log("Not enough coins!");
        }
        
    }
}
