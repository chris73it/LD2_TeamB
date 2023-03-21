using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Controller : MonoBehaviour
{
    public int Level;
    public GameObject canvas;

    int[] integers = new int[] { 3, 4 };

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

    public void InteractLevel()
    {
        int randIndex = Random.Range(0, integers.Length);
        int randValue = integers[randIndex];

        SceneManager.LoadScene(randValue);
    }
}
