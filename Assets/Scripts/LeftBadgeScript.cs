using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftBadgeScript : MonoBehaviour
{
    private BoxCollider2D collider;

    private SpriteRenderer sprenderer;

    public bool playerTouch;


    private void Start()
    {
        playerTouch = false;
        sprenderer = GetComponent<SpriteRenderer>();
        collider = GetComponent<BoxCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerTouch = true;
            sprenderer.enabled = false;
            collider.enabled = false;

        }
        else
        {
            playerTouch = false;
            sprenderer.enabled = true;
            collider.enabled = true;
        }
    }
}
