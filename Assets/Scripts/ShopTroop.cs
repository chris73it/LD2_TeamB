using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum SlotType { Troop, Inv }; 
public class ShopTroop : MonoBehaviour
{
    [SerializeField]
    Image image;

    [SerializeField]
    TMP_Text text;

    public Troop troop;
    public SlotType slot;

    private void Start()
    {
        if (slot == SlotType.Troop)
        {
            image.sprite = troop.getSprite();
            text.text = "" + troop.getCost();
        }
    }
    public void Reset()
    {
        image.sprite = troop.getSprite();
        text.text = "" + troop.getCost();
        this.GetComponent<Button>().interactable = true;
    }
}
