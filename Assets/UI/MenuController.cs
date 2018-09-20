using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    public GameObject panelOpciones;

    public void Jugar()
    {
        SceneManager.LoadScene("armas");
    }

    public void Opciones ()
    {
        panelOpciones.SetActive(true);
    }

    public void Salir()
    {
        Application.Quit();

    }

    public void Cerrar()
    {
        panelOpciones.SetActive(false);
    }

}
