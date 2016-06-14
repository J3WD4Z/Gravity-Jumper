using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FuelManager : MonoBehaviour
{
	public Text FuelText;
	private GameObject playercache;
	private PlayerScript psc;

	// Use this for initialization
	void Start ()
	{
		playercache = GameManager.Instance.mPlayer;
		psc = playercache.GetComponent<PlayerScript>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (psc != null)
		{
			FuelText.text = "Fuel = " + psc.m_Fuel;
		}
	}
}
