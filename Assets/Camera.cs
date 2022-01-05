using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    Rigidbody rb;
    void Start()
    {
         rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Vector3.forward * 1.5f); 
       transform.position += transform.forward * Time.deltaTime * 500;
    }
}
