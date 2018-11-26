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

    public void MakeGoat(int num = 1)
    {
        GoatCounter += Mathf.Clamp(num, -1, 1234);
        GoatCounter = (int)Mathf.Clamp(GoatCounter, 0, 10000000000);
        UpdateUI();
    }

    public void UpdateUI()
    {
        goatText.text = GoatCounter.ToString();
    }
}