using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour {


    public Transform[] player1;
    public Transform[] player2;

    public float PlaceX1;
    public float PlaceY1;
    public float PlaceX2;
    public float PlaceY2;

    void Start () {

        PlaceX1 = Random.Range(-9, 9);
        PlaceY1 = Random.Range(-4, 7);
        PlaceX2 = Random.Range(-9, 9);
        PlaceY2 = Random.Range(-4, 7);
        for (int i = 0; i <= player1.Length-1; i++)
        {
            Instantiate(player1[i], new Vector3(PlaceX1-i, PlaceY1-i, 0), Quaternion.identity);
            Instantiate(player2[i], new Vector3(PlaceX2-i, PlaceY2-i, 0), Quaternion.identity);
        }
        
    }
	
	void Update ()
    {
        
    }
}
