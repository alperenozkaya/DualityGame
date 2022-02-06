using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RightBadge : MonoBehaviour
{
    private BoxCollider2D collider;

    private SpriteRenderer sprenderer;

    public bool enemyTouch;

    private void Start()
    {
        enemyTouch = false;
        
        sprenderer = GetComponent<SpriteRenderer>();
        collider = GetComponent<BoxCollider2D>();

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            enemyTouch = true;
            sprenderer.enabled = false;
            collider.enabled = false;
        }
        else
        {
            enemyTouch = false;
            sprenderer.enabled = true;
            collider.enabled = true;
        }
    }
}
