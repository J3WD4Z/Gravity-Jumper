using UnityEngine;
using System.Collections;

public class HealthManager : MonoBehaviour
{
    public int initHealth = 3;
    public int healthCoutner;

	void Start ()
    {
        healthCoutner = initHealth;
	}
	
	void Update ()
    {
	
	}

    public void loseHealth()
    {
        healthCoutner--;
    }
}
