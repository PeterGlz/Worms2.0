using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomInstante : MonoBehaviour {

    public GameObject[] m_prefabs;
    public int m_amount;

    public Transform m_left, m_right;

    public float m_WaitTime = 0.01f;

    private bool m_isInstantitating;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
        {
            if(!m_isInstantitating)
            {
                StartCoroutine(RandomInstantiate());
            }
        }
	}

    IEnumerator RandomInstantiate()
    {
        m_isInstantitating = true;
        for(int i=0;i<m_amount;i++)
        {
            Instantiate(m_prefabs[Random.Range(0, m_prefabs.Length)], new Vector3(Random.Range(m_left.position.x, m_right.position.x), transform.position.y, transform.position.z), Random.rotation);
            yield return new WaitForSeconds(m_WaitTime);

        }
        m_isInstantitating = false;
    }
}
