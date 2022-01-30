using UnityEngine;

/// <summary>
/// An implementation for sound to use in AudioScript.
/// Using it in anywhere else is obsolete.
/// </summary>
[System.Serializable]
public class Sound {
    public string name; // Clip name

    public AudioClip clip; // Actual clip

    [Range(0f, 1f)]
    public float volume; //Volume in range between 0 and 1

    [Range(.1f, 3f)]
    public float pitch; // Pitch in range between 0.1 and 3

    public bool loop; // To check if sound is to be looped

    [HideInInspector]
    public AudioSource source; // Audio source (hidden in inspector)
}