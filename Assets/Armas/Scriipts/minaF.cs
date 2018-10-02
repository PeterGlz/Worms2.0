using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minaF : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(explosion());
    }

    IEnumerator explosion()
    {
        yield return new WaitForSeconds(4);
        Destroy(gameObject);
    }
}
