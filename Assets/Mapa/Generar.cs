using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generar : MonoBehaviour {


    Vector2 vec;
    public GameObject[][] mapa;
    public int x;
    public int y;
    public GameObject[] esquina_izq;
    public GameObject[] esquina_der;
    public GameObject[] arriba;
    public GameObject[] izq;
    public GameObject[] der;
    public GameObject[] centro;



    void Start () {

        



        vec = new Vector2(x, y);
       mapa = new GameObject[(int)vec.x][];

        for(int i = 0; i <= x-1;i++)
        {
            
            for (int j = 0; j <= y-1;j++)
            {
                mapa[i] = new GameObject[(int)vec.y];
                if (i == 0 && j==0)
                {
                    mapa[i][j] = esquina_izq[Random.Range(0, esquina_izq.Length)];

                }
                if(i == 0 && j > 0 && j < y-1)
                {
                    mapa[i][j] = arriba[Random.Range(0, arriba.Length)];
                }
                if(i == 0 && j== y-1)
                {
                    mapa[i][j] = esquina_der[Random.Range(0, esquina_der.Length)];
                }


                if(x>1  && j == 0 && i >0)
                {
                    mapa[i][j] = izq[Random.Range(0, izq.Length)];
                }

                if(i>0&& j > 0 && j < y-1)
                {
                    mapa[i][j] = centro[Random.Range(0, centro.Length)];
                }
                if(i>0&& j == y-1)
                {
                    mapa[i][j] = der[Random.Range(0, der.Length)];
                }



                Instantiate(mapa[i][j], new Vector3(j, -i, 0), Quaternion.identity);

            }
        }

       // mapa[0][0] = esquina_izq[Random.Range(0, esquina_izq.Length)];
        //Instantiate(mapa[0][0], new Vector3(0, 0, 0), Quaternion.identity);

    }
	
	
	void Update () {
		
	}
}
