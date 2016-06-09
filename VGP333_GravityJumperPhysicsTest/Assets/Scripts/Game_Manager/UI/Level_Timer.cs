using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Level_Timer : MonoBehaviour
{
    private GameOver gameOver;

    public float startingTime;

    private Text timerText;

    void Start ()
    {
        timerText = GetComponent<Text>();
    }
	
	void Update ()
    {
        startingTime -= Time.deltaTime;
        timerText.text = "Remaining Time\n " + Mathf.Round(startingTime);

        if (startingTime <= 0)
        {
            startingTime = 0;
            gameOver.gameOver();
        }
    }
}