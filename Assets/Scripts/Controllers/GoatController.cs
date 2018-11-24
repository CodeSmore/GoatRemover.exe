using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoatController : MonoBehaviour {

    public int GoatCounter = 0;

    public Text goatText;

	// Use this for initialization
	void Start () {
        UpdateUI();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MakeGoat()
    {
        GoatCounter += 1;
        UpdateUI();
    }

    public void UpdateUI()
    {
        goatText.text = GoatCounter.ToString();
    }
}
