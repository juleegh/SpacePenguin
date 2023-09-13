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
            Destroy(gameObject);
        }
    }

    public float GetCurrentHealth()
    {
        return currentHealth;
    }
}
