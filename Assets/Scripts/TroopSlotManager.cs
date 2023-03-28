using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TroopSlotManager : MonoBehaviour
{
    [SerializeField]
    List<Transform> children;
    float rotation_offset = 0;
    float offset = 1.6f;
    int filledSlots = 0;

    public InputManager input;

    /*
    void Start()
    {
        foreach (Transform g in this.GetComponentsInChildren<Transform>())
        {
            children.Add(g);
            //Debug.Log(g);
        }

        foreach (var item in children)
        {
            if (item.parent != this)
            {
                children.Remove(item);
            }
        }
    }*/

    void Update()
    {
        if (input.horizontal != 0 || input.vertical != 0)
        {
            rotation_offset += (Mathf.Abs(input.horizontal) + Mathf.Abs(input.vertical)) / 500;
        }
        else
        {
            rotation_offset += Time.deltaTime * 1;
        }
        
        for (int i = 0; i < children.Count; i++)
        {

            filledSlots = 0;
            foreach (Transform c in children) {
                if (c.childCount > 0)
                {
                    filledSlots++;
                }
            }

            float angle = 45;//360 / filledSlots;
            
            Debug.Log(filledSlots + " rotating");

            Vector3 polarPos = new Vector3(offset * (Mathf.Sin(angle * i)) + this.transform.position.x, offset * (Mathf.Cos(angle * i)) + this.transform.position.y, 0);
            children[i].position = polarPos;
        }
        
    }
}
