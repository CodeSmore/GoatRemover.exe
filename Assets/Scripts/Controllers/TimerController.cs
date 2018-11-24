using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour {

    public int gameDurationInSeconds = 60;
    public Text timerText;

    private float currentTimeLeft = 0;

	// Use this for initialization
	void Start () {
        currentTimeLeft = gameDurationInSeconds;	
	}
	
	// Update is called once per frame
	void Update () {
        UpdateTimer();	
	}

    void UpdateTimer()
    {
        currentTimeLeft -= Time.deltaTime;

        timerText.text = Mathf.CeilToInt(currentTimeLeft).ToString();
    }
}
