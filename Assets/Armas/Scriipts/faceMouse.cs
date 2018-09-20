using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faceMouse : MonoBehaviour
{
    /*private Vector3 worldpos;
    private float mouseX;
    private float mouseY;
    private float cameraDif;

    public GameObject fpc;

    void Start()
    {
        cameraDif = Camera.main.transform.position.y - fpc.transform.position.y;
    }*/

    void Update ()
    {
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        Vector3 lookPos = Camera.main.ScreenToWorldPoint(mousePos);
        lookPos = lookPos - transform.position;
        float angle = Mathf.Atan2(lookPos.y, lookPos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        //faceM();
    }

    /*void LookAtMouse()
    {
        mouseX = Input.mousePosition.x;

        mouseY = Input.mousePosition.y;

        worldpos = Camera.main.ScreenToWorldPoint(new Vector3(mouseX, mouseY, cameraDif));

        Vector3 turretLookDirection = new Vector3(worldpos.x, fpc.transform.position.y, worldpos.z);

        fpc.transform.LookAt(turretLookDirection);
    }*/

    /*void faceM()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y
        );

        transform.up = direction;
    }*/
}
