using UnityEngine;
using System.Collections;

public class CheckpointSystem : MonoBehaviour
{
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

    public void ResetObject(Transform t)
    {
        if (lastCheckpointIndex == -1)
            t.position = startPosition;
        else
            t.position = lastCheckpoint;

        Rigidbody rb = t.GetComponent<Rigidbody>();
        rb.velocity = Vector3.zero;
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
