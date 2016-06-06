using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthManager : MonoBehaviour
{
    private GameOver gameOver;

    public int initHealth;

    private int healthCoutner;
    private Text healthText;

    void Start ()
    {
        healthCoutner = initHealth;

        healthText = GetComponent<Text>();
    }
	
	void Update ()
    {
        healthText.text = "Life: " + healthCoutner;

        if (healthCoutner <= 0)
        {
            gameOver.gameOver();
        }
    }

    public void loseHealth()
    {
        healthCoutner--;
    }
}
