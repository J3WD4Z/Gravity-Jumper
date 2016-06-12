using UnityEngine;
using System.Collections;

public class LifePlus : MonoBehaviour
{
    public bool wasTriggered = false;
    
    void Start ()
    {
	
	}
	
	void Update ()
    {
        if (CompareTag("Player"))
        {

            Debug.Log("Life +1.");
        }
    }

   void OncollisionEnter(Collision other)
    {
        // Still working on this
    }
}
