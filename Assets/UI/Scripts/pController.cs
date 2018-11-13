using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pController : MonoBehaviour {

    public GameObject PauseMenu;

    public bool inPause = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && inPause == false)
        {
            //Time.timeScale = 0;
            PauseMenu.SetActive(true);
            inPause = true;
        }

        else if (Input.GetKeyDown(KeyCode.P) && inPause == true)
        {
            PauseMenu.SetActive(false);
            // Time.timeScale = 1;
            inPause = false;
        }
    }

    public void Continue()
    {
        PauseMenu.SetActive(false);
        //Time.timeScale = 1;
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
