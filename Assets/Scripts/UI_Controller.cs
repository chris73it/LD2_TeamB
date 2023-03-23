using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Controller : MonoBehaviour
{
    public int Level;
    public GameObject canvas;

    int[] Basic = new int[] { };
    int[] Interact = new int[] { 3, 4, 5 };
    int[] Elite = new int[] { 7, 8, 9 };

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
        int randIndex = Random.Range(0, Interact.Length);
        int randValue = Interact[randIndex];

        SceneManager.LoadScene(randValue);
    }
    public void EliteLevel()
    {
        int randIndex = Random.Range(0, Elite.Length);
        int randValue = Elite[randIndex];

        SceneManager.LoadScene(randValue);
    }
}
