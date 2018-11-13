using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisilSalchicha : MonoBehaviour
{
    private armas usarSalchicha;
    public GameObject explotar;
    public float vel;
    public Vector3 direction = Vector3.right;
    private Turnos cambiandoT;

    void Start ()
    {
		usarSalchicha = FindObjectOfType<armas>();
        StartCoroutine(Explosion(8));
        cambiandoT = FindObjectOfType<Turnos>();
    }
	
	void Update ()
    {
        transform.Translate(direction * vel * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Piso")
        {
            StartCoroutine(Explosion(0.0f));
        }
    }

    IEnumerator Explosion(float duracion)
    {
        yield return new WaitForSeconds(duracion);
        vel = 0;
        explotar.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        usarSalchicha.objSuelo = false;
        cambiandoT.CambiarTurno();
        Destroy(gameObject);
    }
}
