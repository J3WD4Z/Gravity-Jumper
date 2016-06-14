using UnityEngine;
using System.Collections;

public class GroundScript : MonoBehaviour
{
<<<<<<< HEAD
	public int shotsgiven;
	public float fuelgiven;

	private GameObject gun;

=======
>>>>>>> 24dc71427b38ee8125611ab50efd489aacc049cc
	//public float force;
	//public bool pull;
	//private Transform cache_tf;
	//public GameObject player;

	// Use this for initialization
	void Start ()
	{
		//pull = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
<<<<<<< HEAD
		if(player.GetComponent<PlayerScript>().hasnotshot)
		{
			gun.GetComponent<GunScript>().m_Ammo = shotsgiven;
			player.GetComponent<PlayerScript>().m_Fuel = fuelgiven;
		}
=======
>>>>>>> 24dc71427b38ee8125611ab50efd489aacc049cc
		/*
		if (player != null)
		{
			if (pull)
			{
				Vector3 p_force = Vector3.Normalize(findvec(player.transform.position, cache_tf.position));
				p_force *= force;
				player.GetComponent<Rigidbody>().AddForce(p_force);
				Debug.DrawRay(player.transform.position, p_force, Color.red);
			}
		
			if (player.GetComponent<PlayerScript>().hasnotshot == true)
			{
				pull = false;
			}
		}*/
	}

	void OnTriggerEnter(Collider other)
	{
		//if(other.GetComponent<PlayerScript>() != null)
		//{
		//	pull = true;
		//}
	}

	Vector3 findvec(Vector3 a,Vector3 b)
	{
		Vector3 result;
		result.x = b.x - a.x;
		result.y = b.y - a.y;
		result.z = b.z - a.z;
		return result;
	}

	public void OnDrawGizmos()
	{
		//Gizmos.DrawWireSphere(transform.position, GetComponent<SphereCollider>().radius * transform.lossyScale.x);
	}
}
