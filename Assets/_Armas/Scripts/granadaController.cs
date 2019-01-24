using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class granadaController : MonoBehaviour
{
    private armas usarGranada;
    public GameObject explotar;
    public float vel;
    public Vector3 direction = Vector3.right;
    private Turnos cambiandoT;

    void Start ()
    {
        usarGranada = FindObjectOfType<armas>();
        cambiandoT = FindObjectOfType<Turnos>();
        StartCoroutine(Explosion());
    }
	
	void Update ()
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
        yield return new WaitForSeconds(0.5f);
        usarGranada.objSuelo = false;
        cambiandoT.CambiarTurno();
        Destroy(gameObject);
    }
}
