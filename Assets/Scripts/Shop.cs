using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shop : MonoBehaviour
{
    [SerializeField]
    Inventory player;

    [SerializeField]
    TMP_Text text;

    public Items allItems;
    public Troops allTroops;

    public ShopItem item1, item2, item3;
    public ShopTroop troop1, troop2, troop3;

    private void Start()
    {
        updateText();
        Shuffle();
    }

    public void Shuffle()
    {
        if (player.coins.Get() >= 1)
        {

            item1.item = allItems.GetRandom();
            item2.item = allItems.GetRandom();
            item3.item = allItems.GetRandom();

            troop1.troop = allTroops.GetRandom();
            troop2.troop = allTroops.GetRandom();
            troop3.troop = allTroops.GetRandom();

            item1.Reset();
            item2.Reset();
            item3.Reset();

            troop1.Reset();
            troop2.Reset();
            troop3.Reset();

            player.coins.Subtract(1);

            updateText();

            Debug.Log("Shop Shuffled! -1 coins");
        }
        else
        {
            Debug.Log("Not enough coins!");
        }
    }

    public void updateText()
    {
        text.text = "x" + player.coins.Get();
    }

    public void BuyItem(ShopItem shopItem)
    {
        if (player.coins.Get() >= shopItem.item.getCost())
        {
            player.coins.Subtract(shopItem.item.getCost());
            player.inv.addItem(shopItem.item);
            updateText();
        }
        else
        {
            Debug.Log("Not enough coins!");
        }
        
    }

    public void BuyTroop(ShopTroop shopTroop)
    {
        if (player.coins.Get() >= shopTroop.troop.getCost())
        {
            player.coins.Subtract(shopTroop.troop.getCost());
            player.barracks.addTroop(shopTroop.troop);
            updateText();
        }
        else
        {
            Debug.Log("Not enough coins!");
        }
    }
}
