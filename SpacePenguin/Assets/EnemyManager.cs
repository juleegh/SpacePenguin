using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private static EnemyManager instance;
    private int totalEnemies;
    private int deadEnemies;
    private bool thresholdHasReached = false;
    [SerializeField] private float aggroThreshold = 0.8f;

    public delegate void EnemyEvents();
    public static EnemyEvents ThresholdReached;
    public static EnemyEvents PlayerWonGame;
    public static EnemyEvents EnemyKilled;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    private void Start()
    {
        // By doing this I find all the pigeons in the scene, which allows me to have the total amount
        PigeonPatrol[] allPigeons = GameObject.FindObjectsByType<PigeonPatrol>(FindObjectsSortMode.None);
        totalEnemies = allPigeons.Length;
    }

    public static EnemyManager GetInstance()
    {
        return instance;
    }

    public void IncreaseDeadEnemies()
    {
        deadEnemies++;
        EnemyKilled();
        
        if (GetKillPercentage() >= aggroThreshold & !thresholdHasReached)
        {
            thresholdHasReached = true;
            ThresholdReached();
        }

        if (deadEnemies == totalEnemies)
        {
            PlayerWonGame();
        }
    }

    public int GetDeadEnemies()
    {
        return deadEnemies;
    }

    public int GetTotalEnemies()
    {
        return totalEnemies;
    }

    public float GetKillPercentage()
    {
        return  ((float)deadEnemies / (float)totalEnemies);
    }
}
