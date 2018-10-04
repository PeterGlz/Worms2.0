using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minaF : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(Explosion());
    }

    IEnumerator Explosion()
    {
        yield return new WaitForSeconds(4);
        Destroy(gameObject);
    }
}
