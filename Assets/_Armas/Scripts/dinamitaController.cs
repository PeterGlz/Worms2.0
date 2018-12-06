using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dinamitaController : MonoBehaviour
{
    private armas usarDinamita;
    public GameObject explotar;
    private Turnos cambiandoT;

    void Start()
    {
        usarDinamita = FindObjectOfType<armas>();
        StartCoroutine(Explosion());
        cambiandoT = FindObjectOfType<Turnos>();
    }

    IEnumerator Explosion()
    {
        yield return new WaitForSeconds(4);
        explotar.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        usarDinamita.objSuelo = false;
        cambiandoT.CambiarTurno();
        Destroy(gameObject);
    }
}
