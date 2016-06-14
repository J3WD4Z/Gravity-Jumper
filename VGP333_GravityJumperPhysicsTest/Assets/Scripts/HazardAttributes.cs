using UnityEngine;
using System.Collections;

public class HazardAttributes : MonoBehaviour {

    public float m_Lifetime;

    //Hazard's Own Damping
    public Vector3 m_HazardUpForce; // Force to counter Gravity

    [SerializeField]
    private Rigidbody m_Rigidbody;
    [SerializeField]
    private Transform m_Transform;

	// Use this for initialization
	void Start () {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Transform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
	    if(m_Lifetime <= 0)
        {
            DestroyImmediate(this.gameObject);
        }
        else
        {
            m_Lifetime -= Time.deltaTime;
            m_Rigidbody.AddForce(m_HazardUpForce);
        }
        
	}
}
