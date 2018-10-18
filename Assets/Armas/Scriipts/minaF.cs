using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minaF : MonoBehaviour
{
    private armas usarmina;

    void Start()
    {
        usarmina = FindObjectOfType<armas>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Jugador")
        {
            //StartCoroutine(Explosion());
            Explota();
        }
    }

    private void Explota()
    {
        usarmina.minaSuelo = false;
        Destroy(gameObject);
    }

    /*IEnumerator Explosion()
    {
        yield return new WaitForSeconds(4);
        usarmina.minaSuelo = false;
        Destroy(gameObject);
    }*/
}
