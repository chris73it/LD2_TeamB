using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{
    
    public UI_Controller ui;
    private int waiter = 3;
    

    void Start()
    {
        forestTransfer();
    }

    private IEnumerator Waiter()
    {
        yield return new WaitForSeconds(waiter);

    }

    void forestTransfer()
    {
                ui.InteractLevel();
    }

}
