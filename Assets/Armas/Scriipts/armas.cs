using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armas : MonoBehaviour
{
    public int armaI = 1;
    public GameObject arma1;
    public GameObject arma2;
    public GameObject arma2spawn;
    public GameObject arma3;

    public Transform balin;
    public Transform minas;

    public float angulo;

    public Animator anim;

    void Start ()
    {
        anim = GetComponent<Animator>();
    }

    public Transform myGun;
    RaycastHit hitInfo;
    public LayerMask rayMask;

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            armaI = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            armaI = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            armaI = 3;
        }

        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        Physics.Raycast(Camera.main.ScreenPointToRay(mousePos), out hitInfo, 100, rayMask);
        Vector3 lookPos = hitInfo.point;

        myGun.LookAt(lookPos);

        if (Input.GetMouseButton(0))
        {
            Instantiate(balin, myGun.position, myGun.rotation);
        }

        Debug.DrawLine(Camera.main.ScreenPointToRay(mousePos).origin, hitInfo.point, Color.green);
        Debug.DrawLine(transform.position, lookPos, Color.red);

        /*lookPos = lookPos - transform.position;

        angulo = Mathf.Atan2(lookPos.y, lookPos.x) * Mathf.Rad2Deg;*/

        switch (armaI)
        {
            case 1: //tenedor
                arma1.SetActive(true);
                arma2.SetActive(false);
                arma3.SetActive(false);
                if (Input.GetMouseButtonDown(0))
                {
                    print("algo");
                    anim.SetTrigger("ataque");
                }
                break;

            case 2: //metralleta
                arma1.SetActive(false);
                arma2.SetActive(true);
                arma3.SetActive(false);
                if (Input.GetMouseButton(0))
                {

                    Instantiate(balin, arma2spawn.transform.position, Quaternion.Euler(0,0,angulo));
                }
                    
                break;

            case 3: //mina
                arma1.SetActive(false);
                arma2.SetActive(false);
                arma3.SetActive(true);
                if(Input.GetMouseButtonDown(0))
                {
                    Instantiate(minas, arma3.transform.position, Quaternion.identity);
                }
                break;
        }
	}
}
