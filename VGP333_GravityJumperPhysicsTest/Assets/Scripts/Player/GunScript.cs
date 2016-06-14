using UnityEngine;
using System.Collections;
using System;

public class GunScript : MonoBehaviour
{
	public float force;
	//public float lerptime;
	//private float timer;
	//public bool test
	public GameObject player;
	private Transform playertrans;
	private Rigidbody playerbody;
	private Vector3 move;
    //private Vector3 playerpos;
    //private bool lrp;
    public int m_Ammo;
    public GameObject m_GunSmokeOb;
    private ParticleSystem m_GunSmokePS;

    // Use this for initialization
    void Start ()
	{
		//lrp = false;
		//timer = 0;
		playertrans = player.GetComponent<Transform>();
		playerbody = player.GetComponent<Rigidbody>();
        m_GunSmokePS = m_GunSmokeOb.GetComponent<ParticleSystem>();
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetButtonDown("Fire1") && m_Ammo > 0)
		{
            m_GunSmokeOb.transform.Rotate(new Vector3(90.0f, 0.0f, 0.0f));
            m_GunSmokePS.Play();
            m_Ammo--;
			move = Vector3.zero;
			move = move - (this.transform.forward * force);
			playerbody.AddForce(move);
			player.GetComponent<PlayerScript>().hasnotshot = false;
		}
		
		/*
		timer = 0;
		lrp = true;
		move = player.transform.position;
		playerpos = move;
		move = move - this.transform.forward * distance;
		player.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().m_Jumping = true;
	}
	if (timer < lerptime && lrp)
	{
		timer += Time.deltaTime;
		playertrans.position = Vector3.Lerp(playerpos, move, timer);
	}
	if(timer >= lerptime)
	{
		lrp = false;
	}
	*/
	}
}
