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

    public Dropdown _resolutionDropdown;
    Resolution[] _resolutions;

    void Start()
    {
        _resolutions = Screen.resolutions;
        _resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        int _currentResolution = 0;
        for(int i=0; i < _resolutions.Length; i++)
        {
            string option = _resolutions[i].width + " x " + _resolutions[i].height;
            options.Add(option);

            if(_resolutions[i].width == Screen.currentResolution.width && _resolutions[i].height == Screen.currentResolution.height)
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
        SceneManager.LoadScene("enJuego");
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

    ///-------JUEGO--------------------
    ///
}
