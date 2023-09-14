using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private float currentHealth = 100f;

    public void IncreaseHealth(float healthIncrease)
    {
        currentHealth += healthIncrease;
    }

    public void TakeDamage(float damageTaken)
    {
        currentHealth -= damageTaken;
        if (currentHealth <= 0)
        {
            if (GetComponent<PigeonPatrol>() != null)
            {
                // this means that this health component belongs to an enemy, so I can increase the death counter
                EnemyManager.GetInstance().IncreaseDeadEnemies();
            }
            Destroy(gameObject);
        }
    }

    public float GetCurrentHealth()
    {
        return currentHealth;
    }
}
