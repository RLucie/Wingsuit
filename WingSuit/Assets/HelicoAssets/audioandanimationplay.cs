using UnityEngine;
using System.Collections;

public class audioandanimationplay : MonoBehaviour
{    
    public AudioClip Son;
    public float Volume;
    AudioSource source;
    public bool alreadyPlayed = false;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }
    void OnTriggerEnter()
    {   
        if (!alreadyPlayed)
        {
            source.PlayOneShot(Son, Volume);
            alreadyPlayed = true;
        }
    }
}
