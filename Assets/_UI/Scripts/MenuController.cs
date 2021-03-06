﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MenuController : MonoBehaviour {

    public GameObject pnlOptions;
    public GameObject pnlCredits;
    public GameObject pnlCredits2;
    public GameObject btnMenu;
    public GameObject loadIcon;

    public RawImage LoadingImage;
    public Text progressText;


    public bool inMenu = true;
    public bool inOptions;
    public bool inCredits;
    public bool inCredits2;

    public AudioMixer audioMixer;

    public Dropdown _resolutionDropdown;
    Resolution[] _resolutions;

    void Start()
    {
        _resolutions = Screen.resolutions;
        _resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        int _currentResolution = 0;
        for (int i = 0; i < _resolutions.Length; i++)
        {
            string option = _resolutions[i].width + " x " + _resolutions[i].height;
            options.Add(option);

            if (_resolutions[i].width == Screen.currentResolution.width && _resolutions[i].height == Screen.currentResolution.height)
            {
                _currentResolution = i;
            }
        }
        _resolutionDropdown.AddOptions(options);
        _resolutionDropdown.value = _currentResolution;
        _resolutionDropdown.RefreshShownValue();
    }

    void Update()
    {
        LoadingImage.transform.Rotate(LoadingImage.transform.rotation.x, LoadingImage.transform.rotation.y, LoadingImage.transform.rotation.z - 1f);

        if (LoadingImage.transform.rotation.z <= -1f)
        {
            Debug.Log("HOla");
            LoadingImage.transform.rotation = new Quaternion(0, 0, 0, 0);
        }
       
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

        if (inCredits)
        {
            pnlCredits.SetActive(true);
        } else
        {
            pnlCredits.SetActive(false);
        }

        if (inCredits2)
        {
            pnlCredits2.SetActive(true);
        }
        else
        {
            pnlCredits2.SetActive(false);
        }



        if (Input.GetKeyDown(KeyCode.Escape) && inOptions == true || Input.GetKeyDown(KeyCode.Escape) && inCredits == true)
        {
            inOptions = false;
            inCredits = false;
            inCredits2 = false;
            inMenu = true;
        }

    }

    ///------MENU---------------------------

    public void Jugar()
    {
        SceneManager.LoadScene("Load");
    }

    public void Opciones()
    {
        inOptions = true;
        inCredits = false;
        inCredits2 = false;
        inMenu = false;
    }

    public void Creditos()
    {
        inOptions = false;
        inCredits = true;
        inCredits2 = false;
        inMenu = false;
    }

    public void ChangeCredits()
    {
       if(inCredits == true)
        {
            inCredits = false;
            inCredits2 = true;
        }

       else if(inCredits2 == true)
        {
            inCredits = true;
            inCredits2 = false;
        }
    }

    public void Cerrar()
    {
        inOptions = false;
        inCredits = false;
        inCredits2 = false;
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

    public void setQuality(int _quality)
    {
        QualitySettings.SetQualityLevel(_quality);
    }

    public void setFullScreen(bool _fs)
    {
        Screen.fullScreen = _fs;
    }

    public void setResolution(int _resolution)
    {
        Resolution resolution = _resolutions[_resolution];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
    
}
