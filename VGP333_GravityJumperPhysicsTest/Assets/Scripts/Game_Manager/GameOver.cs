using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameOver : MonoBehaviour
{
    private HealthManager health;
    
	void Start ()
    {
        
	}
	
	void Update ()
    {
	
	}

    public void gameOver()
    {
        Destroy(GameManager.Instance.mPlayer);
        //Display GameOver Screen
        Debug.Log("You lose");
        //Application.LoadLevel("StatingMenu");
        SceneManager.LoadScene("StatingMenu");
    }
}
