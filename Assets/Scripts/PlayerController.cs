using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20.0f;
    public float turnSpeed = 45.0f; 
    public float horizontalInput;
    public float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Let Unity Know I Want to Control Vehicle
        horizontalInput = Input.GetAxis("Horizontal"); //Assign Unity Engine Mapped Button to Control Vehicle
        forwardInput = Input.GetAxis("Vertical");

        //Move vehicle Forward on Input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Move Vehicle Sideways based on Input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

    }
}
