using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armas : MonoBehaviour
{
    public GameObject[] gObjectArmas;
    public KeyCode[] botonArmas;
    public Transform[] tformArmas;
    public Transform[] prefabArmas;

    public GameObject tformCamara;

    public Animator anim1;
    public Animator anim2;

    public LayerMask rayMask;

    public float municion;
    public int armaUsando;
    public bool objSuelo;

    private Turnos cambiandoT;

    RaycastHit hitInfo;

    void Start ()
    {
        armaUsando = 0;
        gObjectArmas[0].SetActive(true);
        objSuelo = false;
        anim1 = GetComponent<Animator>();
        anim2 = GetComponent<Animator>();
        cambiandoT = FindObjectOfType<Turnos>();
    }

    void Update ()
    {
        Inventario();
    }

    private void Inventario()
    {
        if (Input.GetKeyDown(botonArmas[0]))//tenedor en mano
            CambioArma(0, -5);
        else if (Input.GetKeyDown(botonArmas[1]))//pimientero en mano
            CambioArma(1, -15);
        else if (Input.GetKeyDown(botonArmas[2]))//huevo en mano
            CambioArma(2, -6);
        else if (Input.GetKeyDown(botonArmas[3]))//albondiga en mano
            CambioArma(3, -9);
        else if (Input.GetKeyDown(botonArmas[4]))//hot dog en mano
            CambioArma(4, -13);
        else if (Input.GetKeyDown(botonArmas[5]))//baguette en mano
            CambioArma(5, -5);
        else if (Input.GetKeyDown(botonArmas[6]))//mostaza en mano
            CambioArma(6, -9);
        else if (Input.GetKeyDown(botonArmas[7]))//pollo en mano
            CambioArma(7, -13);
        else if (Input.GetKeyDown(botonArmas[8]))//salami en mano
            CambioArma(8, -6);

        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        Physics.Raycast(Camera.main.ScreenPointToRay(mousePos), out hitInfo, 100, rayMask);
        Vector3 lookPos = hitInfo.point;
        /*Debug.DrawLine(Camera.main.ScreenPointToRay(mousePos).origin, hitInfo.point, Color.green);
        Debug.DrawLine(transform.position, lookPos, Color.red);*/

        switch (armaUsando)
        {
            case 0: //usar tenedor
                if (Input.GetMouseButtonDown(0))
                {
                    anim1.SetTrigger("Atck1");
                    Debug.Log("ataco");
                } break;
            case 1: //usar pimientero uzi
                tformArmas[0].LookAt(lookPos);
                if (Input.GetMouseButton(0) && municion > 0)
                {
                    Instantiate(prefabArmas[0], tformArmas[0].position, tformArmas[0].rotation);
                    municion--;
                    if(municion <= 0)
                    {
                        cambiandoT.CambiarTurno();
                    }
                } break;
            case 2: //usar mina huevo
                if (Input.GetMouseButtonDown(0) && !objSuelo)
                {
                    Instantiate(prefabArmas[1], gObjectArmas[2].transform.position, Quaternion.identity);
                    objSuelo = true;
                } break;
            case 3://usar granada albondiga
                tformArmas[1].LookAt(lookPos);
                if (Input.GetMouseButtonDown(0) && !objSuelo)
                {
                    Instantiate(prefabArmas[2], tformArmas[1].transform.position, tformArmas[1].rotation);
                    objSuelo = true;
                } break;
            case 4: //usar hot-dog cohete
                tformArmas[2].LookAt(lookPos);
                if (Input.GetMouseButtonDown(0) && !objSuelo)
                {
                    Instantiate(prefabArmas[3], tformArmas[2].position, tformArmas[2].rotation);
                    objSuelo = true;
                } break;
            case 5: //usar baguette
                if(Input.GetMouseButtonDown(0))
                {
                    anim2.SetTrigger("atck2");
                } break;
            case 6: //usar gas mostaza
                tformArmas[3].LookAt(lookPos);
                if (Input.GetMouseButtonDown(0) && !objSuelo)
                {
                    Instantiate(prefabArmas[4], tformArmas[3].transform.position, tformArmas[3].rotation);
                    objSuelo = true;
                } break;
            case 7: //usar pollo misil
                tformArmas[4].LookAt(lookPos);
                if (Input.GetMouseButtonDown(0) && !objSuelo)
                {
                    Instantiate(prefabArmas[5], tformArmas[4].transform.position, tformArmas[4].rotation);
                    objSuelo = true;
                    tformCamara.SetActive(false);
                    tformCamara.SetActive(true);
                } break;
            case 8: //usar salami dinamita
                if (Input.GetMouseButtonDown(0) && !objSuelo)
                {
                    Instantiate(prefabArmas[6], gObjectArmas[8].transform.position, Quaternion.identity);
                    objSuelo = true;
                } break;
        }
    }

    private void CambioArma(int armaU, int distanciaCam)
    {
        armaUsando = armaU;

        for(int i = 0; i < 9; i++)
        {
            if(i != armaU)
                gObjectArmas[i].SetActive(false);
            else
                gObjectArmas[i].SetActive(true);
        }

        tformCamara.transform.position = new Vector3(transform.position.x, transform.position.y, distanciaCam);
    }
}
