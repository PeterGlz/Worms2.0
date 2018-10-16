using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minaF : MonoBehaviour
{
    private armas usarmina;

    void Start()
    {
        StartCoroutine(Explosion());
        usarmina = FindObjectOfType<armas>();
    }

    IEnumerator Explosion()
    {
        yield return new WaitForSeconds(4);
        usarmina.minaSuelo = false;
        Destroy(gameObject);
    }
}
