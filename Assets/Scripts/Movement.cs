using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    private BoxCollider2D collider;

    private SpriteRenderer sprenderer;

    public ParticleSystem particle;

    public AudioSource deathSound;

    public GameObject bullet;

    private float speed = 10.0f;
    private float horizontalInput;

    private Rigidbody2D rb;

    [SerializeField] private AudioSource fire;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        collider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.C))
        {
            ChangeGravity();
        }

        if (gameObject.CompareTag("Player") && horizontalInput != 0)
        {
            {
                Move(1);
            }
        }

        if (gameObject.CompareTag("Enemy") && horizontalInput != 0)
        {
            Move(-1);

        }


        if (Input.GetKeyDown(KeyCode.Space) && gameObject.CompareTag("Player"))
        {
            Fire();
        }

        if (gameObject.CompareTag("Player") && transform.position.x > -0.175f)
        {
            gameObject.transform.position = new Vector2(-0.175f, transform.position.y);
        }

        if (gameObject.CompareTag("Enemy") && transform.position.x < 0.175f)
        {
            gameObject.transform.position = new Vector2(0.175f, transform.position.y);
        }

       

    }

    void Move(int direction)
    {
        transform.Translate(Vector2.right * horizontalInput * direction * speed * Time.deltaTime);

    }

    void ChangeGravity()
    {
        rb.gravityScale *= -1;
        transform.Rotate(Vector2.right * 180);
    }

    void Fire()
    {
        Vector2 bulletSpawnPosition = new Vector2(gameObject.transform.position.x + 0.1f,
            gameObject.transform.position.y);

        Instantiate(bullet, bulletSpawnPosition, bullet.transform.rotation);
        fire.Play();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            deathSound.Play();
            Instantiate(particle, transform.position, transform.rotation);
            sprenderer = gameObject.GetComponent<SpriteRenderer>();
            sprenderer.enabled = false;
            collider.enabled = false;
            StartCoroutine("Die");
        }
    }

    IEnumerator Die()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}