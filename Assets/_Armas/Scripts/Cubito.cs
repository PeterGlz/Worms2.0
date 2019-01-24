using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubito : MonoBehaviour
{
    Rigidbody2D rb;

    void Start ()
    {
        Color nuevoColor = Random.ColorHSV();
        ActualizarColor(nuevoColor);
    }

    void ActualizarColor(Color _color)
    {
        GetComponent<MeshRenderer>().material.color = _color;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "explosion")
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "agua")
        {
            print("chango");
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }

}
