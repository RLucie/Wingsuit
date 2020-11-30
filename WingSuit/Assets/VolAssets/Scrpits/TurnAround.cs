using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnAround : MonoBehaviour
{
    public PlayerDeath playerDeath;
    public PlayerMovement playerMovement;

    public Vector3 distance;

    public bool isAtDistance;
    
    public float movementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        movementSpeed = 60f;
        isAtDistance = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerDeath.isDead == true)
        {
            if (isAtDistance == false)
            {
                StartCoroutine("PlaceAtDistance");
                transform.Translate(Vector3.back * movementSpeed * Time.deltaTime);
                transform.Translate(Vector3.up * movementSpeed * Time.deltaTime * 0.25f);
            }
            else
            {
                transform.RotateAround(playerMovement.player.transform.position, Vector3.up, movementSpeed * Time.deltaTime);
            }    
        }
    }

    IEnumerator PlaceAtDistance()
    {

        while (distance.z > -100)
        {
            distance = transform.localPosition;
            yield return null;
        }

        isAtDistance = true;
    }
}