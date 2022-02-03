using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepJumping : MonoBehaviour
{
    private float rayLength = .8f;
    private bool grounded;
    private Rigidbody rb;
    private float jumpHight = 2f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        grounded = false;
    }

    private void FixedUpdate()
    {
        CheckForRayCastHit();
        if(grounded == true)
        {
            rb.AddForce(Vector3.up * jumpHight, ForceMode.Impulse);
        }
    }
    private void CheckForRayCastHit()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, rayLength))
        {
            grounded = true;
        }
        else { grounded = false; }
    }
}
