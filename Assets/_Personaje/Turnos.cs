using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turnos : MonoBehaviour
{
    public GameObject[] jugadores;
    public int turno;
    public int equipo1;
    public int equipo2; 

    void Start()
    {
        turno = 0;
        equipo1 = 4;
        equipo2 = 4;
        StartCoroutine(CrearTurnos(6, 0));
    }

    private void Update()
    {
        

        
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

    public void VaciarTurnos(int equipo)
    {
        if(equipo == 1)
        {
            print("Ha muerto jugador del equipo 1");
            equipo1--;

            if (equipo1 <= 0)
            {
                equipo1 = 0;
                print("Equipo 2 ha ganado");
            }
        }
        else if(equipo == 2)
        {
            print("Ha muerto jugador del equipo 2");
            equipo2--;

            if (equipo2 <= 0)
            {
                equipo2 = 0;
                print("Equipo 1 ha ganado");
            }
        }

        for (int i = 0; i < jugadores.Length; i++)
            jugadores[i].SetActive(true);

        for (int i = 0; i < jugadores.Length; i++)
        {
            jugadores[i] = null;
        }

        StartCoroutine(CrearTurnos(0, 1));
    }
}
