using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class misilPollo : MonoBehaviour
{
    private armas usarPollo;
    public GameObject explotar;
    public float vel;
    public Vector3 direction = Vector3.right;

    void Start()
    {
        usarPollo = FindObjectOfType<armas>();
        StartCoroutine(Explosion(8));
    }

    void Update()
    {
        transform.Translate(direction * vel * Time.deltaTime);
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
        Destroy(gameObject);
    }
}
