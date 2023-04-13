using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DraggableItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Camera cam;
    private bool previouslyEquipped = false;

    public Image image;
    public Transform nearestSlot, lastSlot;
    public Troops barracks;

    public Troop troop;

    bool setupDone = false;

    void Start()
    {
        cam = Camera.main;
    }

    public void Setup(Troop trooper)
    {
        troop = trooper;
        image.sprite = trooper.getSprite();


        GameObject[] AllSlots = GameObject.FindGameObjectsWithTag("inv");

        sortByDistance(AllSlots);
        nearestSlot = AllSlots[0].transform;
        lastSlot = nearestSlot;
        lastSlot.transform.tag = "inv_filled";

        transform.position = nearestSlot.transform.position;

        setupDone = true;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin Drag");
        if (lastSlot != null)
        {
            lastSlot.transform.tag = "inv";
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("Dragging");
        transform.position = cam.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (setupDone)
        {
            Debug.Log("End Drag");
            GameObject[] AllSlots = GameObject.FindGameObjectsWithTag("inv");

            sortByDistance(AllSlots);
            nearestSlot = AllSlots[0].transform;

            transform.position = nearestSlot.transform.position;

            lastSlot = nearestSlot;
            lastSlot.transform.tag = "inv_filled";

            if (nearestSlot.transform.parent.tag == "active")
            {
                //add to player inventory
                barracks.addTroop(troop);
                previouslyEquipped = true;
            }
            else if (previouslyEquipped)
            {
                barracks.removeTroop(troop);
                previouslyEquipped = false;
            }
        }
    }

    void sortByDistance(GameObject[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            float d1 = Vector2.Distance(transform.position, array[i].transform.position);
            float d2 = Vector2.Distance(transform.position, array[0].transform.position);
            if (d1 < d2)
            {
                GameObject temp = array[0];
                array[0] = array[i];
                array[i] = temp;
            }
        }
    }
}
