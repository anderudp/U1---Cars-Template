using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuiController : MonoBehaviour
{
    public float startTime;
    public float currentTime;
    public float bestTime;

    public Text timerText;
    public Text bestTimeText;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        bestTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = Time.time - startTime;
        timerText.text = "Time: " + Math.Round(currentTime, 2);
        bestTimeText.text = "Best: " + Math.Round(bestTime, 2);
    }
}
