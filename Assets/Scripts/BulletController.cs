using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Rigidbody2D rb;

    public AudioSource bounce1;
    public AudioSource bounce2;
    public AudioSource bounce3;


    private float speed = 3000.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.right * speed * Time.deltaTime, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < 0)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.black;
        }

        if (transform.position.x > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right, ForceMode2D.Impulse);
        }

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Player") && !collision.gameObject.CompareTag("Enemy"))
        {
            int randomNumber = Random.Range(0, 4);

            switch (randomNumber)
            {
                case 0:
                    bounce1.Play();
                    break;
                case 1:
                    bounce2.Play();
                    break;
                case 2:
                    bounce3.Play();
                    break;
            }
        }
    }

}
