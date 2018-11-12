using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gasColider : MonoBehaviour
{
    private armas usarGas;
    public GameObject explotar;
    public float vel;
    public Vector3 direction = Vector3.right;
    private Turnos cambiandoT;

    void Start()
    {
        usarGas = FindObjectOfType<armas>();
        StartCoroutine(Explosion());
        cambiandoT = FindObjectOfType<Turnos>();
    }

    void Update()
    {
        transform.Translate(direction * vel * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Piso")
        {
            vel = 0;
        }
    }

    IEnumerator Explosion()
    {
        yield return new WaitForSeconds(4);
        explotar.SetActive(true);
        yield return new WaitForSeconds(5);
        usarGas.objSuelo = false;
        cambiandoT.CambiarTurno();
        Destroy(gameObject);
    }
}
