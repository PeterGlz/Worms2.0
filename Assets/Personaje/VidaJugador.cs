using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaJugador : MonoBehaviour
{
    public float vida;
    private Turnos muerteTurno;

	void Start ()
    {
        vida = 200.0f;
        muerteTurno = FindObjectOfType<Turnos>();
    }

    void Update()
    {
        if(vida <= 0)
        {
            vida = 0.0f;
            Destroy(gameObject);
            muerteTurno.VaciarTurnos();
        }
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
            vida -= 10;
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
