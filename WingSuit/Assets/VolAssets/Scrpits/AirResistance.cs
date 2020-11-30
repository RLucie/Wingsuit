using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirResistance : MonoBehaviour
{
    public CharacterController controller;

    public FlyStart flyStart;

    public float downForce;
    public float coefDivideForce;
    public float flyingForce;

    // Start is called before the first frame update
    void Start()
    {
        downForce = 150f;
        flyingForce = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        if (flyStart.hasJumped == true)
        {
            Vector3 move = transform.up * -1;
            controller.Move(move * (flyingForce + downForce) * Time.deltaTime);

            coefDivideForce = 1 + (Time.deltaTime / 10);

            downForce /= coefDivideForce;
        }
    }
}
