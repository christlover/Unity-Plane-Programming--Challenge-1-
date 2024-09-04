using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller_Spin : MonoBehaviour
{
    private float Propeller_rotationSpeed = 1000;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, Propeller_rotationSpeed * Time.deltaTime);
    }
}
