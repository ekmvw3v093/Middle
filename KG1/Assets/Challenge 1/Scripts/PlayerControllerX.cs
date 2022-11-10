using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float upSpeed;
    public float rightSpeed;
    public float rotationSpeed;
    public float verticalInput;
    public float horizontalInput;

   

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.up * upSpeed * verticalInput);
        transform.Translate(Vector3.right * rightSpeed * horizontalInput);
        transform.Translate(Vector3.forward * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(0.01f , 0, 0);
        transform.Rotate(Input.GetAxis("Vertical") * rotationSpeed * -1, 0, 0);
        transform.Rotate(Input.GetAxis("Horizontal") * rotationSpeed * -1, 0, 0);
    }
}
