using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour {
    
    public Transform[] player1;
    public Transform[] player2;

    void Start () {
        for (int i = 4; i <= player1.Length; i++)
        {
            Instantiate(player1[0], new Vector3(Random.Range(-24, -20), Random.Range(-3, 15), 0), Quaternion.identity);
            Instantiate(player1[1], new Vector3(Random.Range(-19, -15), Random.Range(-3, 15), 0), Quaternion.identity);
            Instantiate(player1[2], new Vector3(Random.Range(-14, -10), Random.Range(-3, 15), 0), Quaternion.identity);
            Instantiate(player1[3], new Vector3(Random.Range(-9, -5), Random.Range(-3, 15), 0), Quaternion.identity);

            Instantiate(player2[0], new Vector3(Random.Range(5, 9), Random.Range(-3, 15), 0), Quaternion.identity);
            Instantiate(player2[1], new Vector3(Random.Range(10, 14), Random.Range(-3, 15), 0), Quaternion.identity);
            Instantiate(player2[2], new Vector3(Random.Range(15, 19), Random.Range(-3, 15), 0), Quaternion.identity);
            Instantiate(player2[3], new Vector3(Random.Range(20, 24), Random.Range(-3, 15), 0), Quaternion.identity);
        }
    }
}
