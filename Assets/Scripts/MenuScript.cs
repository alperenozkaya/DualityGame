using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    public GameObject Controller;
    public GameObject MainMenu;
    public void playGame()
    {
        PlayerPrefs.DeleteKey("score");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void returnToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void controllers()
    {
        Controller.SetActive(true);
        MainMenu.SetActive(false);
    }

    public void backToMainMenu()
    {
        Controller.SetActive(false);
        MainMenu.SetActive(true);
    }

        
        

}
