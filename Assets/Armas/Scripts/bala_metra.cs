using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala_metra : MonoBehaviour
{
    [SerializeField] private float vel;
    [SerializeField] private Vector3 direction = Vector3.right;
	
	void Update ()
    {
        transform.Translate(direction * vel * Time.deltaTime);
        Destroy(gameObject, 2);
    }
}
