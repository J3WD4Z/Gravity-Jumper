﻿using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour
{
    private HealthManager health;
    
	void Start ()
    {
        
	}
	
	void Update ()
    {
	
	}

    public void gameOver()
    {
		GameManager.Instance.mCheckPointSystem.RespawnPlayer ();
        //Display GameOver Screen
        Debug.Log("You lose");
    }
}
