using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PickUps : MonoBehaviour
{
    private int score;
    private Text scoreText;

	void Start ()
    {
        scoreText = GetComponent<Text>();
	}
	
	void Update ()
    {
        UpdateScore(0);
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
