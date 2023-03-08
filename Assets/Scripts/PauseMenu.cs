using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public InputManager input;
    public GameObject Canvas;
    bool Paused = false, holdingButton = false;

    void Start()
    {
        Canvas.gameObject.SetActive(false);
    }
    void Update()
    {

        if (input.pause && !holdingButton)
        {
            holdingButton = true;
            Paused = !Paused;
            if (Paused)
            {
                pause();
            }
            else
            {
                resume();
            }
        }
        if (!input.pause)
        {
            holdingButton = false;
        }

    }

    public void pause()
    {
        Canvas.gameObject.SetActive(true);
        Time.timeScale = 0f;
        input.enabled = false;
    }

    public void resume()
    {
        Time.timeScale = 1f;
        Canvas.gameObject.SetActive(false);
        input.enabled = true;
    }

    public void resetHoldingButton()
    {
        holdingButton = false;
        Paused = false;
    }
}
