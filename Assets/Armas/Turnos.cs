using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turnos : MonoBehaviour
{
    public GameObject[] jugadores;
    public GameObject[] personajes;
    public int turno;

    void Start()
    {
        turno = 0;
        jugadores = GameObject.FindGameObjectsWithTag("Inventario");
        for (int i = 0; i<jugadores.Length; i++)
        {
            if(i != turno)
                jugadores[i].SetActive(false);
        }
    }

    void Update ()
    {

	}

    public void CambiarTurno()
    {
        turno++;

        if (turno >= jugadores.Length)
            turno = 0;

        for(int i = 0; i<jugadores.Length; i++)
        {
            if (i != turno)
                jugadores[i].SetActive(false);
            else
                jugadores[i].SetActive(true);
        }
    }


}
