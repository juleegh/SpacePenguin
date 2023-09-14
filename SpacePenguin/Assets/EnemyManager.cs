using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private static EnemyManager instance;
    private int totalEnemies;
    private int deadEnemies;

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
