using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyStart : MonoBehaviour
{
    public bool hasJumped;

    // Start is called before the first frame update
    void Start()
    {
        hasJumped = false;
    }

    // Update is called once per frame
    void Update()
    {
        float jump = Input.GetAxis("Jump");

        if (jump == 1)
        {
            hasJumped = true;
        }
    }
}
