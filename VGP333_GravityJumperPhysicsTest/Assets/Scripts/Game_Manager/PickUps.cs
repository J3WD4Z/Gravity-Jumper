using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PickUps : MonoBehaviour
{
    public Text scoreText;
    private int score;

	void Start ()
    {
        UpdateScore(0);
	}
	
	void Update ()
    {
	
	}

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag( "PickUp" ) )
        {
            other.gameObject.SetActive(false);
            UpdateScore(score + 1);
        }
    }

    public void UpdateScore(int newScore)
    {
        score = newScore;
        scoreText.text = "Score: " + score.ToString();
    }
}
