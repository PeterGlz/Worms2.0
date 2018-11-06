using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {

    private Rigidbody rb;

    public float StopTime = 5;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Invoke("MakeKinematic", StopTime);
    }

    void MakeKinematic()
    {
        rb.isKinematic = true;
        rb.useGravity = false;
    }
}
