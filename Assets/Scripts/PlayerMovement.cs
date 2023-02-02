using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public InputManager input;
    public Character player;
    Rigidbody2D rb;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        if (input.horizontal != 0 || input.vertical != 0)
        {
            rb.velocity = new Vector2(input.horizontal, input.vertical).normalized * player.speed;
        }
        else
        {
            rb.velocity = new Vector2(0f, 0f);
        }
    }
}
