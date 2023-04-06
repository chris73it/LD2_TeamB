using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour
{
    public Character health;
    private float hp;
    public GameObject canvas;

    void Update()
    {
        hp = health.currentHealth;
        if (hp <= 0)
        {
            canvas.SetActive(true);
        }
    }
}
