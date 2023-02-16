using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopItem : MonoBehaviour
{
    [SerializeField]
    Image image;

    [SerializeField]
    TMP_Text text;

    public Item item;

    private void Start()
    {
        image.sprite = item.getSprite();
        text.text = "" + item.getCost();
    }

    public void Reset()
    {
        image.sprite = item.getSprite();
        text.text = "" + item.getCost();
        this.GetComponent<Button>().interactable = true;
    }
}
