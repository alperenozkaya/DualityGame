using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamyteScripts : MonoBehaviour
{
    public AudioSource explosion;

    private PolygonCollider2D collider;

    private SpriteRenderer sprenderer;

    public ParticleSystem explodeAnim;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<PolygonCollider2D>();
        sprenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Explode()
    {
        yield return new WaitForSeconds(2);
        explosion.Play();
        Instantiate(explodeAnim, transform.position, transform.rotation);
        sprenderer.enabled = false;
        collider.enabled = false;
    }
}
