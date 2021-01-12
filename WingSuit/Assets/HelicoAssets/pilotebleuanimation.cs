using UnityEngine;
using System.Collections;

public class pilotebleuanimation : MonoBehaviour
{
    public AnimationClip Scene1;
    Animation source;
    public bool alreadyPlayed = false;

    void Start()
    {
        source = GetComponent<Animation>();
    }
    void OnTriggerEnter()
    {
        if (!alreadyPlayed)
        {
            source.Play();
            alreadyPlayed = true;
        }
    }
}
