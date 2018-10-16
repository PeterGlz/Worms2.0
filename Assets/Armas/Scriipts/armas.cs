using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armas : MonoBehaviour
{
    public GameObject arma1;
    public GameObject arma2;
    public GameObject arma3;
    public Transform camara;
    public Transform balin;
    public Transform minas;
    public Transform uzi;
    public Animator anim;
    public LayerMask rayMask;

    [SerializeField] private float municion;
    public int armaUsando;
    public bool minaSuelo;

    RaycastHit hitInfo;

    void Start ()
    {
        anim = GetComponent<Animator>();
    }

    void Update ()
    {
        Inventario();

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
    }

    private void Tenedor()
    {
        arma1.SetActive(true);
        arma2.SetActive(false);
        arma3.SetActive(false);
        camara.transform.position = new Vector3(transform.position.x, transform.position.y, -5);
    }

    private void Metralleta()
    {
        arma1.SetActive(false);
        arma2.SetActive(true);
        arma3.SetActive(false);
        camara.transform.position = new Vector3(transform.position.x, transform.position.y, -10);
    }

    private void Mina()
    {
        arma1.SetActive(false);
        arma2.SetActive(false);
        arma3.SetActive(true);
        camara.transform.position = new Vector3(transform.position.x, transform.position.y, -6);
    }
}
