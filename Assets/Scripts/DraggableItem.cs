using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Camera cam;
    public Transform nearestSlot;

    void Start()
    {
        cam = Camera.main;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin Drag");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragging");
        transform.position = cam.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Drag");
        GameObject[] AllSlots = GameObject.FindGameObjectsWithTag("inv");

        sortByDistance(AllSlots);
        nearestSlot = AllSlots[0].transform;

        transform.position = nearestSlot.transform.position;
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
