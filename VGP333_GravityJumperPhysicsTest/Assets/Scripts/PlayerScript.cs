using UnityEngine;
using System.Collections;


public class PlayerScript : MonoBehaviour
{
	public bool rotating;
	public Vector3 strafedir;
	public Camera m_Camera;
	public Camera b_Camera;
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
    [SerializeField]
    private int m_Ammo;
    [SerializeField]
    private float m_Fuel;
    [SerializeField]
    private bool m_Jetpack;
    private Vector3 m_JetForce;
    
        
	

    // Use this for initialization
    void Start ()
	{
        m_Fuel = 500.0f;
		m_MouseLook = this.GetComponent<MyMouseLook>();
		m_Camera.enabled = true;
		cache_rb = this.GetComponent<Rigidbody>();
		cache_tf = this.GetComponent<Transform>();
		m_MouseLook.Init(cache_tf, m_Camera.transform);
        m_Jetpack = false;
        m_JetForce = new Vector3(0.0f, 10.0f, 0.0f);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButton("r"))
		{
			b_Camera.enabled = true;
			m_Camera.enabled = false;
		}
		else
		{
			b_Camera.enabled = false;
			m_Camera.enabled = true;
		}
		m_Velocity = this.GetComponent<Rigidbody>().velocity;
        RotateView();

        #region Ground Movement

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
        #endregion
        
        if (m_Velocity.y < m_GravLimit)//v: Limit the Downward Velocity that Gravity can impose. Make things easier for the player.
        {
            m_Velocity.y = m_GravLimit;
        }

        #region Jetpack Code

        if(m_Fuel <= 0.0f)
        {
            m_Jetpack = false;
        }

        if(Input.GetButton("Fire2") && m_Fuel > 0.0f)
        {
            cache_rb.AddForce(m_JetForce);
            m_Fuel = m_Fuel - 0.5f;
            m_Jetpack = true;
        }

        if(Input.GetButtonUp("Fire2") && m_Fuel > 0.0f )
        {
            m_Jetpack = false;
        }

        if(m_Jetpack == true)
        {

            if(Input.GetKey(KeyCode.W))
            {
                cache_tf.Translate(Vector3.forward * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.A))
            {
                cache_tf.Translate(Vector3.left * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.S))
            {
                cache_tf.Translate(Vector3.back * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.D))
            {
                cache_tf.Translate(Vector3.right * Time.deltaTime);
            }
        }

        #endregion

    }

    void FixedUpdate()
	{
		m_MouseLook.UpdateCursorLock();
	}

    //v: Changes player state, doesn't need references
	void OnTriggerEnter(Collider other)
	{
		if (other.GetComponent<GroundScript>() != null)
		{
			onground = true;
		}
	}

	private void RotateView()
	{
		Quaternion rotation = Quaternion.AngleAxis(180, Vector3.up);
		Quaternion player = cache_tf.localRotation;
		Quaternion cam = m_Camera.transform.localRotation;
		
		m_MouseLook.LookRotation(ref player,ref cam);

		cache_tf.localRotation = player;
		b_Camera.transform.localRotation = rotation * cam;
		m_Camera.transform.localRotation = cam;
	}

	private Vector3 resultant(Vector3 a, Vector3 b)
	{
		Vector3 result;
		result.x = a.x + b.x;
		result.y = a.y + b.y;
		result.z = a.z + b.z;
		return result;
	}

    //v: Dot Product
	private Vector3 multiplyvec(Vector3 a,Vector3 b)
	{
		Vector3 result;
		result.x = a.x * b.x;
		result.y = a.y * b.y;
		result.z = a.z * b.z;
		return result;
	}

}
