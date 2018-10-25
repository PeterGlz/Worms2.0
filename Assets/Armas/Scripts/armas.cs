using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armas : MonoBehaviour
{
    [SerializeField] private GameObject[] gObjectArmas;
    [SerializeField] private KeyCode[] botonArmas;

    [SerializeField] private Transform tformCamara;
    [SerializeField] private Transform tformUzi;
    [SerializeField] private Transform tformBalaUzi;
    [SerializeField] private Transform tformMina;
    [SerializeField] private Transform tformGranadaMano;
    [SerializeField] private Transform tformGranada;
    [SerializeField] private Transform tformGasMano;
    [SerializeField] private Transform tformGas;
    [SerializeField] private Transform tformDinamita;

    [SerializeField] private Animator anim;

    [SerializeField] private LayerMask rayMask;

    [SerializeField] private float municion;
    private int armaUsando;
    public bool objSuelo;

    RaycastHit hitInfo;

    public float i;

    void Start ()
    {
        armaUsando = 1;
        gObjectArmas[0].SetActive(true);
        objSuelo = false;
        anim = GetComponent<Animator>();
    }

    void Update ()
    {
        Inventario();
	}

    private void Inventario()
    {
        if (Input.GetKeyDown(botonArmas[0]))
        {
            armaUsando = 1;
            CambioArma(0, -5);
        }
        else if (Input.GetKeyDown(botonArmas[1]))
        {
            armaUsando = 2;
            CambioArma(1, -15);
        }
        else if (Input.GetKeyDown(botonArmas[2]))
        {
            armaUsando = 3;
            CambioArma(2, -6);
        }
        else if (Input.GetKeyDown(botonArmas[3]))
        {
            armaUsando = 4;
            CambioArma(3, -9);
        }
        else if (Input.GetKeyDown(botonArmas[6]))
        {
            armaUsando = 7;
            CambioArma(6, -9);
        }
        else if (Input.GetKeyDown(botonArmas[8]))
        {
            armaUsando = 9;
            CambioArma(8, -6);
        }

        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        Physics.Raycast(Camera.main.ScreenPointToRay(mousePos), out hitInfo, 100, rayMask);
        Vector3 lookPos = hitInfo.point;
        /*Debug.DrawLine(Camera.main.ScreenPointToRay(mousePos).origin, hitInfo.point, Color.green);
        Debug.DrawLine(transform.position, lookPos, Color.red);*/
        i = gObjectArmas[3].transform.rotation.x;

        switch (armaUsando)
        {
            case 1: //tenedor
                if (Input.GetMouseButtonDown(0))
                {
                    anim.SetTrigger("ataque");
                } break;
            case 2: //uzi
                tformUzi.LookAt(lookPos);
                if (Input.GetMouseButton(0) && municion > 0)
                {
                    Instantiate(tformBalaUzi, tformUzi.position, tformUzi.rotation);
                    municion--;
                } break;
            case 3: //mina
                if (Input.GetMouseButtonDown(0) && !objSuelo)
                {
                    Instantiate(tformMina, gObjectArmas[2].transform.position, Quaternion.identity);
                    objSuelo = true;
                } break;
            case 4://granada
                tformGranadaMano.LookAt(lookPos);
                if (Input.GetMouseButtonDown(0) && !objSuelo)
                {
                    
                    Instantiate(tformGranada, gObjectArmas[3].transform.position, Quaternion.identity);
                    objSuelo = true;
                }break;
            case 7: //gas mostaza
                tformGasMano.LookAt(lookPos);
                if (Input.GetMouseButtonDown(0) && !objSuelo)
                {
                    Instantiate(tformGas, gObjectArmas[6].transform.position, Quaternion.identity);
                    objSuelo = true;
                }
                break;
            case 9: //dinamita
                if (Input.GetMouseButtonDown(0) && !objSuelo)
                {
                    Instantiate(tformDinamita, gObjectArmas[8].transform.position, Quaternion.identity);
                    objSuelo = true;
                }break;
        }
    }

    private void CambioArma(int armaU, int distanciaCam)
    {
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
