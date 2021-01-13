using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreCounter : MonoBehaviour
{
    public GameManager gameManager;
    void Start()
    {
        gameManager.score = 0f;
    }

    private void OnTriggerEnter(Collider other)
    {
        gameManager.score += 1;
    }
}
