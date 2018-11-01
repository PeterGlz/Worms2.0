using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class misilPollo : MonoBehaviour
{
    public float vel;
    public Vector3 direction = Vector3.right;

    void Start()
    {

    }

    void Update()
    {
        transform.Translate(direction * vel * Time.deltaTime);
        Destroy(gameObject, 10);
    }
}
