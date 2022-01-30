using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftBadgeScript : MonoBehaviour
{
    public bool playerTouch;

    private void Start()
    {
        playerTouch = false;    
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerTouch = true;
 
        }
        else
        {
            playerTouch = false;
        }
    }
}
