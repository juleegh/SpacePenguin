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
        float enemiesPercentage = ((float) deadEnemies / (float)totalEnemies);
        if (enemiesPercentage >= aggroThreshold & !thresholdHasReached)
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
}
