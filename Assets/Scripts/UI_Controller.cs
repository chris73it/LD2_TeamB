using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Controller : MonoBehaviour
{

    public int Level;
    public GameObject canvas;

    public void StartGame()
    {
        SceneManager.LoadScene(Level);
        canvas.SetActive(false);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(Level);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Quit()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(Level);
    }
}
