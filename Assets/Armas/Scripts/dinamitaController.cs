using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dinamitaController : MonoBehaviour
{
    private armas usarDinamita;
    public GameObject explotar;

    void Start()
    {
        usarDinamita = FindObjectOfType<armas>();
        StartCoroutine(Explosion());
    }

    IEnumerator Explosion()
    {
        yield return new WaitForSeconds(4);
        explotar.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        usarDinamita.objSuelo = false;
        Destroy(gameObject);
    }
}
