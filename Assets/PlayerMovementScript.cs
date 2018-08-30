using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{

    public Rigidbody rb;
    public float horizontalMovement;
    public float verticalMovement;

    public float movementSpeed = 10.0f;


    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        PlayerMovement();
	}

    void PlayerMovement()
    {
        rb.velocity = new Vector3(horizontalMovement * movementSpeed * Time.fixedDeltaTime, rb.velocity.y, verticalMovement * movementSpeed * Time.fixedDeltaTime);
    }
}
