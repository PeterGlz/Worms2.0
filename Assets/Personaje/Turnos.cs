using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turnos : MonoBehaviour
{
    public GameObject[] jugadores;
    public int turno;

    void Start()
    {
        turno = 0;
        StartCoroutine(CrearTurnos(2, 0));
    }

    IEnumerator CrearTurnos(int tempo, int nuevo)
    {
        yield return new WaitForSeconds(tempo);
        jugadores = GameObject.FindGameObjectsWithTag("Inventario");
        for (int i = 0; i < jugadores.Length; i++)
        {
            Debug.Log("Funciona");
            if (i != turno)
                jugadores[i].SetActive(false);
        }
        if (nuevo == 1)
            Activando();
    }

    public void CambiarTurno()
    {
        turno++;

        if (turno >= jugadores.Length)
            turno = 0;

        Activando();
    }

    public void Activando()
    {
        for (int i = 0; i < jugadores.Length; i++)
        {
            if (i != turno)
                jugadores[i].SetActive(false);
            else
                jugadores[i].SetActive(true);
        }
    }

    public void VaciarTurnos()
    {
        for (int i = 0; i < jugadores.Length; i++)
            jugadores[i].SetActive(true);

        for (int i = 0; i < jugadores.Length; i++)
        {
            jugadores[i] = null;
        }

        StartCoroutine(CrearTurnos(0, 1));
    }
}
