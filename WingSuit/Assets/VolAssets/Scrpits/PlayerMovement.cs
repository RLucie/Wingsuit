using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public GameObject player;

    public FlyStart flyStart;

    public float speed = 150f;
    public float rotationSpeed = 1f;

    private float roll;
    public float rollSpeed = 50f;
    public float rollAngle;

    private float pitch;
    public float pitchSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (flyStart.hasJumped == true)
        {
            roll = Input.GetAxis("Horizontal");
            pitch = Input.GetAxis("Vertical");

            transform.Rotate(Vector3.back * roll * Time.deltaTime * rollSpeed);

            rollAngle = transform.eulerAngles.z;
            rollAngle = (rollAngle > 180) ? rollAngle - 360 : rollAngle;

            transform.RotateAround(player.transform.position, Vector3.down, rollAngle * Time.deltaTime * rotationSpeed);
            transform.Rotate(Vector3.right * pitch * Time.deltaTime * pitchSpeed);

            Vector3 move = transform.forward * 1;
            controller.Move(move * speed * Time.deltaTime);
        }
    }
}
