using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public Text timeText;

    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        isPaused = false;
        Debug.Log("Resuming the game");
    }

    void Pause()
    {
        Time.timeScale = 0f;
        isPaused = true;
        Debug.Log("Pause");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}