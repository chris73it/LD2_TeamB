using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopTroop : MonoBehaviour
{
    [SerializeField]
    Image image;

    [SerializeField]
    TMP_Text text;

    public Troop troop;

    private void Start()
    {
        image.sprite = troop.getSprite();
        text.text = "" + troop.getCost();
    }
    public void Reset()
    {
        this.GetComponent<Button>().interactable = true;
    }
}
