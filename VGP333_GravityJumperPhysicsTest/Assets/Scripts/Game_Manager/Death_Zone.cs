using UnityEngine;
using System.Collections;

public class Death_Zone : MonoBehaviour
{    
	void Start ()
    {
    }

	void Update ()
    {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag( "Player" ) )
        {
            HealthManager _health = other.GetComponent<HealthManager>();
            _health.takeDmg();  
            GameManager.Instance.RespawnPlayer();

            Debug.Log("Health Taken.");
                    
        }
    }
}

