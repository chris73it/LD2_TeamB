using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{
    public Wave[] waves;
    public UI_Controller ui;
    private int waiter = 3;
    void Start()
    {
        StartCoroutine(Waiter());
    }

    private IEnumerator Waiter()
    {
        yield return new WaitForSeconds(waiter);

    }

    void Update()
    {
        //if (gameObject is finished)
        //{
        //    forestTransfer();
        //}
        //if (gameObjectElite is finished)
        //{

        //}
    }

    void forestTransfer()
    {
            if (waves.Length == 0)
            {
                ui.InteractLevel();
            }
        
    }
    void eliteTransfer()
    {
        if (waves.Length == 0)
        {
            ui.InteractLevel();
        }

    }
}
