using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthManager : MonoBehaviour
{
    public Text healthText;

    public int initHealth;

    private int healthCoutner;

    void Start ()
    {
       healthCoutner = initHealth;
    }
	
	void Update ()
    {
        healthText.text = "Life: " + healthCoutner;
        if (healthCoutner <= 0)
        {
            GameManager.Instance.mGameOver.gameOver();
        }
    }

    public void takeDmg()
    {
       healthCoutner--;     
    }
}
