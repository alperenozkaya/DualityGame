using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Audio : MonoBehaviour
{
    public AudioClip asd;

    // Start is called before the first frame update
    void Start()
    {
        asd.LoadAudioData();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
