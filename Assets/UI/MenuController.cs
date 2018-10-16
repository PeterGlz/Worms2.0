using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MenuController : MonoBehaviour {

    public GameObject pnlOptions;
    public GameObject btnMenu;
    //public GameObject pnlPause;

    public bool inMenu = true;
    public bool inOptions;

    public AudioMixer audioMixer;

    void Update()
    {
        if (inMenu)
        {
            btnMenu.SetActive(true);
        } else {
            btnMenu.SetActive(false);
        }

        if (inOptions)
        {
            pnlOptions.SetActive(true);
        } else
        {
            pnlOptions.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Escape) && inOptions == true)
        {
            inOptions = false;
            inMenu = true;
        }
    }

    ///------MENU---------------------------

    public void Jugar()
    {
        Debug.Log("Play");
        //SceneManager.LoadScene("armas");
    }

    public void Opciones ()
    {
        inOptions = true;
        inMenu = false;
    }

    public void Cerrar()
    {
        inOptions = false;
        inMenu = true;
    }

    public void Salir()
    {
        Application.Quit();
    }

    ///-------OPCIONES-----------------
    ///

    public void setVolume(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
    }

    ///-------JUEGO--------------------
    ///

    public void Continue()
    {
        Time.timeScale = 1;
        //pnlPause.SetActive(false);

    }

}
