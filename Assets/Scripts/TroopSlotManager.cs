using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TroopSlotManager : MonoBehaviour
{
    [SerializeField]
    List<Transform> children;
    float angle = 0;
    float offset = 1.6f;

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
            angle += (Mathf.Abs(input.horizontal) + Mathf.Abs(input.vertical)) / 500;
        }
        else
        {
            angle += Time.deltaTime * 1;
        }

        for (int i = 0; i < children.Count; i++)
        {
            children[i].position = new Vector3 ((Mathf.Sin((45 * i) + angle) * offset) + transform.position.x, (Mathf.Cos((45 * i) + angle) * offset) + transform.position.y, 0);
        }
    }
}
