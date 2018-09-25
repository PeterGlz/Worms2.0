using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala_metra : MonoBehaviour
{
    public float vel;
	
	void Update ()
    {
        //Vector3 algo = new Vector3(0,0,1);
        transform.Translate(Vector3.right * vel * Time.deltaTime);

        Destroy(gameObject, 2);
    }
}
