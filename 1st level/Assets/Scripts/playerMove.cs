using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 10f;
    public float rayLength;
    private bool grounded;
    public float jumpHight;
    public float realSpeed;

    private void Start()
    {
        grounded = false;
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {

        //move right and left
        if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-speed, 0f, 0f);
        }
        if(Input.GetKey(KeyCode.D))
        {
            rb.AddForce(speed, 0f, 0f);
        }
        //jump
        if(grounded == true & Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpHight, ForceMode.Impulse);
        }


        //Ray cast stuff
        CheckForRayCastHit();
    }
    private void CheckForRayCastHit()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, Vector3.down, out hit, rayLength))
        {
            grounded = true;
        } else { grounded = false; }
    }
}
