using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armas : MonoBehaviour
{
    [SerializeField] private GameObject gObjectTenedor;
    [SerializeField] private GameObject gObjectUzi;
    [SerializeField] private GameObject gObjectMina;

    [SerializeField] private Transform tformCamara;
    [SerializeField] private Transform tformUzi;
    [SerializeField] private Transform tformBalaUzi;
    [SerializeField] private Transform tformMina;

    [SerializeField] private KeyCode btnTenedor;
    [SerializeField] private KeyCode btnUzi;
    [SerializeField] private KeyCode btnMina;

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
        if (Input.GetKeyDown(btnTenedor))
        {
            armaUsando = 1;
            Tenedor();
        }
        else if (Input.GetKeyDown(btnUzi))
        {
            armaUsando = 2;
            Metralleta();
        }
        else if (Input.GetKeyDown(btnMina))
        {
            armaUsando = 3;
            Mina();
        }

        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        Physics.Raycast(Camera.main.ScreenPointToRay(mousePos), out hitInfo, 100, rayMask);
        Vector3 lookPos = hitInfo.point;
        /*Debug.DrawLine(Camera.main.ScreenPointToRay(mousePos).origin, hitInfo.point, Color.green);
        Debug.DrawLine(transform.position, lookPos, Color.red);*/

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
                if (Input.GetMouseButtonDown(0) && !minaSuelo)
                {
                    Instantiate(tformMina, gObjectMina.transform.position, Quaternion.identity);
                    minaSuelo = true;
                } break;
        }
    }

    private void Tenedor()
    {
        gObjectTenedor.SetActive(true);
        gObjectUzi.SetActive(false);
        gObjectMina.SetActive(false);
        tformCamara.transform.position = new Vector3(transform.position.x, transform.position.y, -5);
    }

    private void Metralleta()
    {
        gObjectTenedor.SetActive(false);
        gObjectUzi.SetActive(true);
        gObjectMina.SetActive(false);
        tformCamara.transform.position = new Vector3(transform.position.x, transform.position.y, -10);
    }

    private void Mina()
    {
        gObjectTenedor.SetActive(false);
        gObjectUzi.SetActive(false);
        gObjectMina.SetActive(true);
        tformCamara.transform.position = new Vector3(transform.position.x, transform.position.y, -6);
    }
}
