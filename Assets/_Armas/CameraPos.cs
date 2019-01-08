using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPos : MonoBehaviour
{
    public Transform cameraTarget;

    public float speed = 10;

    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, cameraTarget.position, Time.deltaTime * speed);
        transform.rotation = Quaternion.Lerp(transform.rotation, cameraTarget.rotation, Time.deltaTime * speed);
    }
}
