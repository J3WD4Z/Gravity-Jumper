using UnityEngine;
using System.Collections;

public class Death_Zone : MonoBehaviour
{
    private HealthManager health;
    private GameOver gameOver;

	void Start ()
    {
        health = FindObjectOfType<HealthManager>();
    }

   
	void Update ()
    {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Deathbound"))
        {
            health.loseHealth();
            gameOver.Die();
        }
    }
}

