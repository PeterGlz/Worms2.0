using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armas : MonoBehaviour
{
    public int armaI = 1;
    public GameObject arma1;
    public GameObject arma2;
    public GameObject arma3;

    void Start ()
    {
		
	}
	
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

        switch (armaI)
        {
            case 1: //tenedor
                arma1.SetActive(true);
                arma2.SetActive(false);
                arma3.SetActive(false);
                break;

            case 2: //metralleta
                arma1.SetActive(false);
                arma2.SetActive(true);
                arma3.SetActive(false);
                break;

            case 3: //mina
                arma1.SetActive(false);
                arma2.SetActive(false);
                arma3.SetActive(true);
                break;
        }
	}
}
