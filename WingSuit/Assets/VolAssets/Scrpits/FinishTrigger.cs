using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    public bool hasFinished;
    void Start()
    {
        hasFinished = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        hasFinished = true;
        FindObjectOfType<GameManager>().EndGame();
    }
}
