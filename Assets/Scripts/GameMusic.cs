using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMusic : MonoBehaviour
{

    public Sound sound;

    public static AudioManager instance;


    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    public void adjustMasterVolume(float volume)
    {
        sound.source.volume = volume;
        PlayerPrefs.SetFloat("volume", volume);
            
    }

    public void toggleVoice(bool toggle)
    {
        int i;
        if (toggle) i = 1;
        else i = 0;
        PlayerPrefs.SetInt("toggle", i);
        sound.source.enabled = toggle;
    }
}
