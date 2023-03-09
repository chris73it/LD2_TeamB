using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public bool enabled = true;
    public bool isdead = false;

    public bool leftMouse, rightMouse, pause;
    public float horizontal, vertical;
    void Start()
    {
        enabled = true;
        isdead = false;
    }
    void Update()
    {
        leftMouse = Input.GetMouseButton(0);
        rightMouse = Input.GetMouseButton(1);
        if (enabled)
        {
            horizontal = Input.GetAxisRaw("Horizontal");
            vertical = Input.GetAxisRaw("Vertical");
        }
        if (!isdead)
        {
            pause = Input.GetKeyDown(KeyCode.Escape);
        }
    }
}
