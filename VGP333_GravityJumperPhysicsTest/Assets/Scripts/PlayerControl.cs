using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

    public Vector3 m_PropForce;
    public GameObject m_Player;
    public Vector3 stuff;
    [SerializeField]
    private Rigidbody m_PlayRB;
    [SerializeField]
    private Vector3 m_RotFactor;
    [SerializeField]
    private Vector3 m_Offset;

    // Use this for initialization
    void Start () {
        m_PlayRB = m_Player.GetComponent<Rigidbody>();
        m_Offset = new Vector3(1.0f, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
        m_RotFactor = new Vector3(Input.GetAxis("Mouse Y") * 10, Input.GetAxis("Mouse X") * 10, 0 ) * Time.deltaTime;
        m_Player.transform.Rotate(m_RotFactor);
        if (Input.GetButton("Fire1"))
        {
            //m_PlayRB.AddForce(m_PropForce); //Simple Addforce up
            m_PlayRB.AddForceAtPosition(m_PropForce, this.transform.position - m_Offset ); //Current radius of playerobject = 0.5

        }
        stuff = this.transform.position - m_Offset;
    }
}
