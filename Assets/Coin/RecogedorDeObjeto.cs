using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecogedorDeObjeto : MonoBehaviour
{
    public static int coinsCounts=0;
	// Use this for initialization
	void Start ()
    {
        coinsCounts++;
        Debug.Log("Hay"+ coinsCounts + "monedas");
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            coinsCounts--;
            if (coinsCounts==0)
            {
                Debug.Log("Has Ganado");
                GameObject GameManager = GameObject.Find("GameManager");
                Destroy(GameManager);
                GameObject[] FireWorksSystem = GameObject.FindGameObjectsWithTag("Fireworks");

                foreach (GameObject Fireworks in FireWorksSystem)
                {
                    Fireworks.GetComponent<ParticleSystem>().Play();
                }
            }
            Destroy(gameObject);
        }
        
    }
}
