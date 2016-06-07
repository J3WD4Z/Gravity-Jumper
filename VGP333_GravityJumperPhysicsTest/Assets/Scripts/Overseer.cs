using UnityEngine;
using System.Collections;

public class Overseer : MonoBehaviour {

    public GameObject m_Player;
    public GameObject m_Enemy;
    public int m_Vertices;
    private LineRenderer m_LR;
    [SerializeField]
    private Vector3[] m_Poses;
    

	// Use this for initialization
	void Start () {
        m_Player = GameObject.FindGameObjectWithTag("Player");
        m_Enemy = GameObject.FindGameObjectWithTag("Enemy");
        m_Vertices = 2;
        m_LR = this.GetComponent<LineRenderer>();
        m_LR.SetVertexCount(m_Vertices);
        m_Poses = new Vector3[m_Vertices];
        
	}
	
	// Update is called once per frame
	void Update () {
        m_Poses[0] = m_Player.transform.position;
        m_Poses[1] = m_Enemy.transform.position;
        m_LR.SetPositions(m_Poses);
    }
}
