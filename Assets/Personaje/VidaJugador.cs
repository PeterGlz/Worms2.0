using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaJugador : MonoBehaviour
{
    public float vida;

	void Start ()
    {
        vida = 200;
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "explosion")
        {
            vida -= 20;
            Debug.Log(vida);
        }

        if (collision.gameObject.tag == "bala_uzi")
        {
            vida--;
            Debug.Log(vida);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "gas")
        {
            vida -= 0.5f;
            Debug.Log(vida);
        }
    }
}
