using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class granadaController : MonoBehaviour
{
    private armas usarGranada;
    public GameObject explotar;
    public float vel;
    public Vector3 direction = Vector3.right;

    void Start ()
    {
        usarGranada = FindObjectOfType<armas>();
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
        yield return new WaitForSeconds(1.5f);
        usarGranada.objSuelo = false;
        Destroy(gameObject);
    }
}
