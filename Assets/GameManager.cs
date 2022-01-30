using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<LeftBadgeScript>().playerTouch && FindObjectOfType<RightBadge>().enemyTouch)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
