using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{
    Rigidbody rb;
    bool right;
    bool left;

    void Start()
    {
        rb=GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
     rb.AddForce(Vector3.forward * 1.5f); 
        Vector3 turnRight = new Vector3(2.50f, transform.position.y, transform.position.z);
        Vector3 turnLeft = new Vector3(-2.50f, transform.position.y,transform.position.z);
        
        if(Input.touchCount > 0)
        {
            Touch finger = Input.GetTouch(0);

            if(finger.deltaPosition.x > 55.0f)
            {
                right = true;
                left = false;
            }
          
            if(finger.deltaPosition.x < -55.0f)
            {
                right = false;
                left = true;
            }

            if(right == true)
            {
                transform.position = Vector3.Lerp(transform.position, turnRight, 5* Time.deltaTime);
            }
             if(left == true)
            {
                transform.position = Vector3.Lerp(transform.position, turnLeft, 5* Time.deltaTime);
            }
        }
    }
    void OnCollisionEnter(Collision collision)
{
    if(collision.gameObject.tag.Equals("Car"))
    {
         SceneManager.LoadScene("gameover");
    }
}
}