using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTarget : MonoBehaviour
{
    public CameraPos campos;

    public Transform[] targets;

    public int currentTarget;

    void Start ()
    {
        campos.cameraTarget = targets[currentTarget];
	}
	
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.Q))
        {
            currentTarget--;
            if (currentTarget < 0)
                currentTarget = targets.Length - 1;
            campos.cameraTarget = targets[currentTarget];
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            currentTarget++;
            if (currentTarget >= targets.Length)
                currentTarget = 0;
            campos.cameraTarget = targets[currentTarget];
        }
	}
}
