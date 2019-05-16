﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public GameObject statsScreen;
    public Text timerText;
    private float objectif = 1200f;
    private float timerValue = 0f;

    public static UI_Manager s_Singleton;


    private void Awake()
    {
        if(s_Singleton != null)
        {
            Destroy(gameObject);
        }
        else
        {
            s_Singleton = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timerValue < objectif)
        {
            timerValue += Time.deltaTime;
            UpdateTimerDisplay();
        }
        if(timerValue >= objectif)
        {
            DisplayStatsScreen();
        }
    }
    public void DisplayStatsScreen()
    {
        statsScreen.SetActive(true);
    }
    public void UpdateTimerDisplay()
    {
        timerText.text = timerValue.ToString("00:00");
    }
}