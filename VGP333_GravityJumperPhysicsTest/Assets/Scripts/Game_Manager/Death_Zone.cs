using UnityEngine;
using System.Collections;

public class Death_Zone : MonoBehaviour
{
    private HealthManager health;
    private GameOver gameOver;
    private Checkpoint checkPoint;

	void Start ()
    {
        health = FindObjectOfType<HealthManager>();
    }

	void Update ()
    {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("DeathZone") )
        {
            health.loseHealth();
            checkPoint.checks();
        }
    }
}

