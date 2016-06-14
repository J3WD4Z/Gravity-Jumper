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

	// Use this for initialization
	void Start ()
	{
		//lrp = false;
		//timer = 0;
		playertrans = player.GetComponent<Transform>();
		playerbody = player.GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetButtonDown("Fire1"))
		{
			move = Vector3.zero;
			move = move - (this.transform.forward * force);
			playerbody.AddForce(move);
			player.GetComponent<PlayerScript>().onground = false;
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
