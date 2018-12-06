using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala_metra : MonoBehaviour
{
    public float vel;
    public Vector3 direction = Vector3.right;
	
	void Update ()
    {
        transform.Translate(direction * vel * Time.deltaTime);
        Destroy(gameObject, 2);
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }*/

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
