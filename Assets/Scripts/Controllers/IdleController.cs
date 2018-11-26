using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IdleController : MonoBehaviour
{
    public float idleSpeedIncreaseCoefficient = 0.1f;
    public float idleStartDuration = 10;

    public Image loadingBarImage;

    private float idleSpeed = 1;
    private float timer = 0;
    private int numberOfGoatsCreated = 0;

    private GoatController goatController;

    private void Start()
    {
        goatController = GameObject.FindObjectOfType<GoatController>();
    }

    public void Update()
    {
        UpdateTimer();
        UpdateLoadingBar();
    }

    private void UpdateTimer()
    {
        timer += idleSpeed * Time.deltaTime;
    }

    private void UpdateLoadingBar()
    {
        loadingBarImage.fillAmount = timer / idleStartDuration;

        if (loadingBarImage.fillAmount >= 1)
        {
            IncrementGoatCount();
            loadingBarImage.fillAmount = 0;
            timer = 0;
        }
    }

    private void IncrementGoatCount()
    {
        // goatcontroller MakeGoat()
        int numbGoats = goatController.GoatCounter + 1;

        goatController.MakeGoat(numbGoats);
        numberOfGoatsCreated++;

        UpdateIdleSpeed();
    }

    private void UpdateIdleSpeed()
    {
        idleSpeed = 1 + numberOfGoatsCreated * idleSpeedIncreaseCoefficient;
    }
}
