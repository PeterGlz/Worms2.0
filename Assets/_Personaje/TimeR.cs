using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeR : MonoBehaviour {

    public RawImage Digit1;
    public RawImage Digit2;

    public Texture[] numbers;
    public Text TiempoRest;
    public GameObject _adminT;

    public float _tiempoT;

	
	// Update is called once per frame
	void Update () {

        _tiempoT = _adminT.GetComponent<Turnos>().tiempoT;
        TiempoRest.text = Mathf.RoundToInt(_tiempoT).ToString();

        UpdateImages();
	}

    void UpdateImages()
    {
        switch (Mathf.RoundToInt(_tiempoT))
        {
            case 0:
                Digit2.enabled = false;
                Digit1.texture = numbers[0];
                break;
            case 1:
                Digit2.enabled = false;
                Digit1.texture = numbers[1];
                break;
            case 2:
                Digit2.enabled = false;
                Digit1.texture = numbers[2];
                break;
            case 3:
                Digit2.enabled = false;
                Digit1.texture = numbers[3];
                break;
            case 4:
                Digit2.enabled = false;
                Digit1.texture = numbers[4];
                break;
            case 5:
                Digit2.enabled = false;
                Digit1.texture = numbers[5];
                break;
            case 6:
                Digit2.enabled = false;
                Digit1.texture = numbers[6];
                break;
            case 7:
                Digit2.enabled = false;
                Digit1.texture = numbers[7];
                break;
            case 8:
                Digit2.enabled = false;
                Digit1.texture = numbers[8];
                break;
            case 9:
                Digit2.enabled = false;
                Digit1.texture = numbers[9];
                break;
            case 10:
                Digit2.enabled = true;
                Digit2.texture = numbers[1];
                Digit1.texture = numbers[0];
                break;
            case 11:
                Digit2.enabled = true;
                Digit2.texture = numbers[1];
                Digit1.texture = numbers[1];
                break;
            case 12:
                Digit2.enabled = true;
                Digit2.texture = numbers[1];
                Digit1.texture = numbers[2];
                break;
            case 13:
                Digit2.enabled = true;
                Digit2.texture = numbers[1];
                Digit1.texture = numbers[3];
                break;
            case 14:
                Digit2.enabled = true;
                Digit2.texture = numbers[1];
                Digit1.texture = numbers[4];
                break;
            case 15:
                Digit2.enabled = true;
                Digit2.texture = numbers[1];
                Digit1.texture = numbers[5];
                break;
            case 16:
                Digit2.enabled = true;
                Digit2.texture = numbers[1];
                Digit1.texture = numbers[6];
                break;
            case 17:
                Digit2.enabled = true;
                Digit2.texture = numbers[1];
                Digit1.texture = numbers[7];
                break;
            case 18:
                Digit2.enabled = true;
                Digit2.texture = numbers[1];
                Digit1.texture = numbers[8];
                break;
            case 19:
                Digit2.enabled = true;
                Digit2.texture = numbers[1];
                Digit1.texture = numbers[9];
                break;
            case 20:
                Digit2.enabled = true;
                Digit2.texture = numbers[2];
                Digit1.texture = numbers[0];
                break;
            case 21:
                Digit2.enabled = true;
                Digit2.texture = numbers[2];
                Digit1.texture = numbers[1];
                break;
            case 22:
                Digit2.enabled = true;
                Digit2.texture = numbers[2];
                Digit1.texture = numbers[2];
                break;
            case 23:
                Digit2.enabled = true;
                Digit2.texture = numbers[2];
                Digit1.texture = numbers[3];
                break;
            case 24:
                Digit2.enabled = true;
                Digit2.texture = numbers[2];
                Digit1.texture = numbers[4];
                break;
            case 25:
                Digit2.enabled = true;
                Digit2.texture = numbers[2];
                Digit1.texture = numbers[5];
                break;
            case 26:
                Digit2.enabled = true;
                Digit2.texture = numbers[2];
                Digit1.texture = numbers[6];
                break;
            case 27:
                Digit2.enabled = true;
                Digit2.texture = numbers[2];
                Digit1.texture = numbers[7];
                break;
            case 28:
                Digit2.enabled = true;
                Digit2.texture = numbers[2];
                Digit1.texture = numbers[8];
                break;
            case 29:
                Digit2.enabled = true;
                Digit2.texture = numbers[2];
                Digit1.texture = numbers[9];
                break;
            case 30:
                Digit2.enabled = true;
                Digit2.texture = numbers[3];
                Digit1.texture = numbers[0];
                break;
        }

    }

}
