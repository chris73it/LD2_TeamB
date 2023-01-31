using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType { Evolution, Accessory }

public class Item : MonoBehaviour
{
    [SerializeField]
    private ItemType type;

    [SerializeField]
    private int cost; //1-5

    [SerializeField]
    Sprite sprite;

    public int getCost()
    {
        return cost;
    }

    //what the item does

}
