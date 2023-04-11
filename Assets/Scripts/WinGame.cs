using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour
{
    public Character health;
    public GameObject canvas;
    private float hp;

    void Update()
    {
        hp = health.currentHealth;
        if (hp <= 0)
        {
            canvas.SetActive(true);
        }
    }
}
