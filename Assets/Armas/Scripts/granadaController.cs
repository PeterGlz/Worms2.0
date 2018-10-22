using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class granadaController : MonoBehaviour
{
    private armas usarGranada;
    public float vel;
    [SerializeField] private Vector3 direction = Vector3.right;

    void Start ()
    {
        usarGranada = FindObjectOfType<armas>();
        StartCoroutine(Explosion());
    }
	
	void Update ()
    {
        transform.Translate(direction * vel * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Piso")
        {
            vel = 0;
        }
    }

    IEnumerator Explosion()
    {
        yield return new WaitForSeconds(4);
        usarGranada.objSuelo = false;
        Destroy(gameObject);
    }
}
