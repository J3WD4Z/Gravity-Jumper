using UnityEngine;
using System.Collections;


public class PlayerScript : MonoBehaviour
{
	public Vector3 strafedir;
	public Camera m_Camera;
	private Rigidbody cache_rb;
	private Transform cache_tf;
	public float forspeed;
	public float strafespeed;
	private Vector3 velocity;
	private MyMouseLook m_MouseLook;
	private Quaternion rot;
	public bool onground;
    [SerializeField]
    private Vector3 m_Velocity;
    public float m_GravLimit;
    [SerializeField]
    private Quaternion m_Rotation;

    // Use this for initialization
    void Start ()
	{
		
		m_MouseLook = this.GetComponent<MyMouseLook>();
		cache_rb = this.GetComponent<Rigidbody>();
		cache_tf = this.GetComponent<Transform>();
		m_MouseLook.Init(cache_tf, m_Camera.transform);
	}
	
	// Update is called once per frame
	void Update ()
	{
		RotateView();
		if (onground == true)
		{
			float horizontal = Input.GetAxis("Horizontal");
			float vertical = Input.GetAxis("Vertical");

			if (horizontal == 0)
			{
				cache_rb.velocity = forspeed * vertical * cache_tf.forward;
			}
			else if (vertical == 0)
			{
				cache_rb.velocity = cache_tf.right * horizontal * strafespeed;
			}
			else
			{
				Vector3 forw = forspeed * vertical * cache_tf.forward;
				Vector3 strafe = cache_tf.right * strafespeed * horizontal;
				cache_rb.velocity = resultant(strafe, forw);
			}
		}

        m_Velocity = this.GetComponent<Rigidbody>().velocity;
        m_Rotation = this.GetComponent<Transform>().rotation;

        if (m_Velocity.y < m_GravLimit)
        {
            m_Velocity.y = m_GravLimit;
        }
        
        
    }

	void FixedUpdate()
	{
		m_MouseLook.UpdateCursorLock();
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.GetComponent<GroundScript>() != null)
		{
			onground = true;
		}
	}

	private void RotateView()
	{
		m_MouseLook.LookRotation(cache_tf, m_Camera.transform);
	}

	private Vector3 resultant(Vector3 a, Vector3 b)
	{
		Vector3 result;
		result.x = a.x + b.x;
		result.y = a.y + b.y;
		result.z = a.z + b.z;
		return result;
	}


	private Vector3 multiplyvec(Vector3 a,Vector3 b)
	{
		Vector3 result;
		result.x = a.x * b.x;
		result.y = a.y * b.y;
		result.z = a.z * b.z;
		return result;
	}

}
