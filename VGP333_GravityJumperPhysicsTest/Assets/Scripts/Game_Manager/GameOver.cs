using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour
{
    private HealthManager health;
    private Checkpoint checkPoint;
    

	void Start ()
    {
        
	}
	
	void Update ()
    {
	
	}

    public void gameOver()
    {
        checkPoint.checks();
        //Display GameOver Screen
        Debug.Log("You lose Bro!");
    }
}
