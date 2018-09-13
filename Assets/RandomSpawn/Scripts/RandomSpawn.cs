using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour {

    public GameObject Player1;
    public GameObject Player2;

    public float PlaceX1;
    public float PlaceY1;
    public float PlaceX2;
    public float PlaceY2;

    void Start () {

        PlaceX1 = Random.Range(-9, 9);
        PlaceY1 = Random.Range(-4, 7);
        PlaceX2 = Random.Range(-9, 9);
        PlaceY2 = Random.Range(-4, 7);
        Player1.transform.position = new Vector3(PlaceX1, PlaceY1, 0);
        Player2.transform.position = new Vector3(PlaceX2, PlaceY2, 0);

    }
	
	void Update () {
		
	}
}
