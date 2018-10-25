using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gasColider : MonoBehaviour
{
    private armas usarGas;
    public float vel;
    [SerializeField] private Vector3 direction = Vector3.right;

    void Start()
    {
        usarGas = FindObjectOfType<armas>();
        StartCoroutine(Explosion());
    }

    void Update()
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
        usarGas.objSuelo = false;
        Destroy(gameObject);
    }
}
