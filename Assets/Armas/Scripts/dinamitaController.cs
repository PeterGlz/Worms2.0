using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dinamitaController : MonoBehaviour
{
    private armas usarDinamita;

    void Start()
    {
        usarDinamita = FindObjectOfType<armas>();
        StartCoroutine(Explosion());
    }

    IEnumerator Explosion()
    {
        yield return new WaitForSeconds(4);
        usarDinamita.objSuelo = false;
        Destroy(gameObject);
    }
}
