using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour
{
    public bool wasTriggered = false;
    public int index = 0;

    private Vector3 lastCheckpoint = Vector3.zero;
    private Vector3 startPosition = Vector3.zero;
    private int lastCheckpointIndex = -1;

    void Start ()
    {
        lastCheckpoint = transform.position;
        startPosition = transform.position;
    }
	
	void Update ()
    {
	
	}

    public void checks()
    {
        transform.position = lastCheckpoint;
    }

    public void OnTriggerEnter(Collider other)
    {
        
    Checkpoint ckp = other.GetComponent<Checkpoint>();        
         if (ckp != null && ckp.wasTriggered == false && ckp.index > lastCheckpointIndex)
         {
             lastCheckpoint = other.transform.position;
             ckp.wasTriggered = true;
             lastCheckpointIndex = ckp.index;
         }
         
    }
}
