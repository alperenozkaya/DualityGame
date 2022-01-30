using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool gamePaused = false;
    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused)
            {
                resume();
            }
            else
            {
                pause();
            }
        }
    }

    public void resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gamePaused = false;
    }

    public void pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gamePaused = true;
    }


    public void quitGame()
    {
        Application.Quit();
    }

}
