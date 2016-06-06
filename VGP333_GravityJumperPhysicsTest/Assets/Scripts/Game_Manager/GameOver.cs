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

    public void Die()
    {
        checkPoint.checks();

        if(health.healthCoutner <= 0)
        {
            //Display GameOver Screen
        } 
    }
}
