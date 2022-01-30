using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject dynamite;

    public float spawnTime;
    private float curSpawnTime;

    void Start()
    {
        curSpawnTime = spawnTime;
    }

    void Update()
    {
        curSpawnTime -= 1 * Time.deltaTime;
        if (curSpawnTime <= 0)
        {
            Spawn();
            curSpawnTime = spawnTime;
        }

    }
    void Spawn()
 {
     Instantiate(dynamite, new Vector2(Random.Range(-8f, 8f), Random.Range(-4.5f, 4.5f)), dynamite.transform.rotation);
 }

}

    
      
   