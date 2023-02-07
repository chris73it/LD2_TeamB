using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Troop : MonoBehaviour
{

    [SerializeField]
    private int cost; //1-5

    [SerializeField]
    Sprite sprite;

    public int getCost()
    {
        return cost;
    }

    public Sprite getSprite()
    {
        return sprite;
    }

    //Troop info
}
