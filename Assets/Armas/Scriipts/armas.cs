using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armas : MonoBehaviour
{
    [SerializeField] private GameObject arma1;
    [SerializeField] private GameObject arma2;
    [SerializeField] private GameObject arma3;

    [SerializeField] private Transform transformCamara;
    [SerializeField] private Transform balin;
    [SerializeField] private Transform minas;
    [SerializeField] private Transform uzi;

    [SerializeField] private KeyCode botonTenedor;
    [SerializeField] private KeyCode botonUzi;
    [SerializeField] private KeyCode botonMina;

    [SerializeField] private Animator anim;

    [SerializeField] private LayerMask rayMask;

    [SerializeField] private float municion;
    private int armaUsando;
    public bool minaSuelo;

    RaycastHit hitInfo;

    void Start ()
    {
        armaUsando = 1;
        minaSuelo = false;
        anim = GetComponent<Animator>();
    }

    void Update ()
    {
        Inventario();
	}

    private void Inventario()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            armaUsando = 1;
            Tenedor();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            armaUsando = 2;
            Metralleta();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            armaUsando = 3;
            Mina();
        }

        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        Physics.Raycast(Camera.main.ScreenPointToRay(mousePos), out hitInfo, 100, rayMask);
        Vector3 lookPos = hitInfo.point;

        switch (armaUsando)
        {
            case 1: //tenedor
                if (Input.GetMouseButtonDown(0))
                {
                    anim.SetTrigger("ataque");
                }
                break;
            case 2: //metralleta
                uzi.LookAt(lookPos);
                if (Input.GetMouseButton(0) && municion > 0)
                {
                    municion--;
                    Instantiate(balin, uzi.position, uzi.rotation);
                    /*Debug.DrawLine(Camera.main.ScreenPointToRay(mousePos).origin, hitInfo.point, Color.green);
                    Debug.DrawLine(transform.position, lookPos, Color.red);*/
                }
                break;
            case 3: //mina
                if (Input.GetMouseButtonDown(0) && minaSuelo == false)
                {
                    Instantiate(minas, arma3.transform.position, Quaternion.identity);
                    minaSuelo = true;
                }
                break;
        }
    }

    private void Tenedor()
    {
        arma1.SetActive(true);
        arma2.SetActive(false);
        arma3.SetActive(false);
        transformCamara.transform.position = new Vector3(transform.position.x, transform.position.y, -5);
    }

    private void Metralleta()
    {
        arma1.SetActive(false);
        arma2.SetActive(true);
        arma3.SetActive(false);
        transformCamara.transform.position = new Vector3(transform.position.x, transform.position.y, -10);
    }

    private void Mina()
    {
        arma1.SetActive(false);
        arma2.SetActive(false);
        arma3.SetActive(true);
        transformCamara.transform.position = new Vector3(transform.position.x, transform.position.y, -6);
    }
}
