using UnityEngine;
using System.Collections;

public class HazardAttributes : MonoBehaviour {

    private float m_Lifetime;

	// Use this for initialization
	void Start () {
        m_Lifetime = 10.0f;
	}
	
	// Update is called once per frame
	void Update () {
	    if(m_Lifetime == 0)
        {
            DestroyImmediate(this);
        }
        m_Lifetime -= Time.deltaTime;
	}
}
