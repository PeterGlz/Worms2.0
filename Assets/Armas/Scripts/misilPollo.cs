using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class misilPollo : MonoBehaviour
{
    private armas usarPollo;
    public GameObject explotar;
    public float vel;
    public Vector3 direction = Vector3.right;
    private Turnos cambiandoT;

    void Start()
    {
        usarPollo = FindObjectOfType<armas>();
        StartCoroutine(Explosion(8));
        cambiandoT = FindObjectOfType<Turnos>();
    }

    void Update()
    {
        transform.Translate(direction * vel * Time.deltaTime);

        float j = Input.GetAxis("Vertical");

        transform.Rotate(-j * 50f * Time.deltaTime, 0.0f, 0.0f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Piso")
        {
            StartCoroutine(Explosion(0.1f));
        }
    }

    IEnumerator Explosion(float duracion)
    {
        yield return new WaitForSeconds(duracion);
        vel = 0;
        explotar.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        usarPollo.objSuelo = false;
        cambiandoT.CambiarTurno();
        Destroy(gameObject);
    }
}
