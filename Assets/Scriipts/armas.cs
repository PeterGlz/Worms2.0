﻿using System.Collections;
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
		switch(armaI)
        {
            case 1: //tenedor
                break;

            case 2: //metralleta
                break;

            case 3: //mina
                break;
        }
	}

    void boton1()
    {
        armaI = 1;
    }

    void boton2()
    {
        armaI = 2;
    }

    void boton3()
    {
        armaI = 3;
    }
}
