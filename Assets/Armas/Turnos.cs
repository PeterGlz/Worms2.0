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
        StartCoroutine(CrearTurnos());
    }

    IEnumerator CrearTurnos()
    {
        yield return new WaitForSeconds(1);
        jugadores = GameObject.FindGameObjectsWithTag("Inventario");
        for (int i = 0; i < jugadores.Length; i++)
        {
            Debug.Log("Funciona");
            if (i != turno)
                jugadores[i].SetActive(false);
        }
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
