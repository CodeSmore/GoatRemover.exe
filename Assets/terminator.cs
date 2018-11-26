using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terminator : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnEnable()
    {
        if (Time.frameCount > 20)
        {
            Debug.Log("Quit");
            Application.Quit();
        }

    }
}
