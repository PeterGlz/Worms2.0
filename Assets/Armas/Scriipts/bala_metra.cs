using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala_metra : MonoBehaviour
{
    public Rigidbody rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }
	
	void Update ()
    {
        rb.velocity = new Vector3(10, 0, 0);
    }
}
