using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour
{
    public int Level = 1;
    public GameObject Warp; 
    public Text levelText;

	void Start ()
    {
        DontDestroyOnLoad(GameManager.Instance.mPlayer);
        DontDestroyOnLoad(GameManager.Instance.mCheckPointSystem);
        DontDestroyOnLoad(GameManager.Instance.mDeathZoneObj);
        DontDestroyOnLoad(GameManager.Instance.mHealthManager);
        DontDestroyOnLoad(GameManager.Instance.mTimer);
        DontDestroyOnLoad(GameManager.Instance.mLifePlus);
        DontDestroyOnLoad(GameManager.Instance.mPickUps);
        DontDestroyOnLoad(GameManager.Instance.mTextManager);
        DontDestroyOnLoad(GameManager.Instance.mAiSpawnManager);
        DontDestroyOnLoad(GameManager.Instance.mLevelManager);
        DontDestroyOnLoad(GameManager.Instance.mGameOver);
        
}
	
	void Update ()
    {
	
	}

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && Level == 1)
        {
            SceneManager.LoadScene( "Level02" );
        }
        else if(other.CompareTag("Player") && Level == 2)
        {
            SceneManager.LoadScene("VictoryScene");
        }
    }

    public void OnLevelWasLoaded()
    {
        Level++;
    }
}
