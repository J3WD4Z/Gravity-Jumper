﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Level_Timer : MonoBehaviour
{
    public Text timerText;

    public float startingTime;

    void Start ()
    {
        timerText = GetComponent<Text>();
    }
	
	void Update ()
    {
        startingTime -= Time.deltaTime;
        timerText.text = "Remaining Time\n " + Mathf.Round(startingTime);

        if (startingTime <= 0)
        {
            startingTime = 0;
            GameManager.Instance.mGameOver.gameOver();
        }
    }
}