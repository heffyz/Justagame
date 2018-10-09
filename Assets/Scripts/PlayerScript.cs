using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
    public PlayerScript playermov;
    public Rigidbody rb;
    public float ForwardForce = 2000f;
    public float SidewayForce = 500f;
    // Use this for initialization
    void Start ()
    {
        Debug.Log("yey");
        
	}
	
	// Messing with physics
	void FixedUpdate ()
    {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(SidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("q"))
        {
            rb.AddForce(-SidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
     
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle") {
            playermov.enabled = false;
        }
    }
}
