using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour {

    // Use this for initialization
    public float maxTime = 60f;
    private float countDown = 0f;

    void Start () {
        countDown = maxTime;
	}
	
	// Update is called once per frame
	void Update () {
        countDown -= Time.deltaTime;
        Debug.Log("cuenta atras :" + countDown);
        if (countDown<=0)
        {
            Debug.Log("Has perdido :");
            RecogedorDeObjeto.coinsCounts = 0;
            SceneManager.LoadScene("MainScene");
        }
	}
}
