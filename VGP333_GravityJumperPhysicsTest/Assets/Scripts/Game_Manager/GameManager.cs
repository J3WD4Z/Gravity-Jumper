﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour
{
    private Checkpoint checkPoint;
    private Death_Zone deathZone;
    private GameOver gameOver;
    private HealthManager health;
    private Level_Timer timer;

    private Text healthText;
    private Text timerText;

	void Start ()
    {
        healthText = GetComponent<Text>();
        timerText = GetComponent<Text>();   
    }
	
	void Update ()
    {
	
	}
}
