using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mouse : MonoBehaviour
{
    

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //go to next level
            Debug.Log("Clicked");
        }
    }

}
