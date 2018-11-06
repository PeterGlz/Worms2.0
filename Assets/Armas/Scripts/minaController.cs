using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minaController : MonoBehaviour
{
    private armas usarMina;
    public GameObject explotar;

    void Start()
    {
        usarMina = FindObjectOfType<armas>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Jugador")
        {
            StartCoroutine(Explosion());
        }
    }

    IEnumerator Explosion()
    {
        explotar.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        usarMina.objSuelo = false;
        Destroy(gameObject);
    }
}
