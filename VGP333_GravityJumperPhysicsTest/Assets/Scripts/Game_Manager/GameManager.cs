using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour
{
    private static GameManager s_Instance;
    public static GameManager Instance
    {
        get
        {
            if (s_Instance == null)
            {
                s_Instance = FindObjectOfType<GameManager>();
            }
            return s_Instance;
        }
    }

    public GameObject mPlayer;
    public CheckpointSystem mCheckPointSystem;
    public Death_Zone mDeathZone;
    public GameOver mGameOver;
    public HealthManager mHealthManager;
    public Timer mTimer;
	public LifePlus mLifePlus;
	public PickUps mPickUps;
    public TextManager mTextManager;
	public FuelManager mFuelManager;
}
