using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RightBadge : MonoBehaviour
{
    public bool enemyTouch;

    private void Start()
    {
        enemyTouch = false;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            enemyTouch = true;
            
        }
        else
        {
            enemyTouch = false;
        }
    }
}
