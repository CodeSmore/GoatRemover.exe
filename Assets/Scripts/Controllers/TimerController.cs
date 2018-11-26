using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour {

    public int gameDurationInSeconds = 60;
    public Text timerText;
    public GameObject endPanel;

    private float currentTimeLeft = 0;
    private _4_PostGameDialogue dialogue;
    private bool ContinueTiming = true;

	// Use this for initialization
	void Start () {
        currentTimeLeft = gameDurationInSeconds;
        dialogue = GameObject.FindObjectOfType<_4_PostGameDialogue>();

        endPanel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (ContinueTiming)
        {
            if (currentTimeLeft > 0)
            {
                UpdateTimer();
            }
            else
            {
                // end sequence
                endPanel.SetActive(true);
                dialogue.TriggerDialogue();
                ContinueTiming = false;
            }
        }
	}

    void UpdateTimer()
    {
        currentTimeLeft -= Time.deltaTime;

        timerText.text = Mathf.CeilToInt(currentTimeLeft).ToString();
    }
}
