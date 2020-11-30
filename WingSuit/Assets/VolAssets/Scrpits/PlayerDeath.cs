using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public FlyStart flyStart;

    public bool isDead;
    
    // Start is called before the first frame update
    void Start()
    {
        isDead = false;
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider collider)
    {
        flyStart.hasJumped = false;
        isDead = true;
        FindObjectOfType<GameManager>().GameOver();
    }
}
