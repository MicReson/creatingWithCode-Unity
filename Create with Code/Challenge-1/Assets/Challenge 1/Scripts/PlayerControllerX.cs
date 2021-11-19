using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    private GameObject propellerObject;

    void FixedUpdate()
    {
        propellerObject = GameObject.Find("Propeller");

        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed* Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.left * verticalInput * rotationSpeed * Time.deltaTime);

        propellerObject.transform.Rotate(0.0f, 0.0f, rotationSpeed);
    }
}
