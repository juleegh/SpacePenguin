using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy Qualities")]
public class EnemyQualities : ScriptableObject
{
    [SerializeField] private float regularSpeed;
    [SerializeField] private float aggroSpeed;
    [SerializeField] private Color aggroColor;

    public float GetRegularSpeed()
    {
        return regularSpeed;
    }

    public float GetAggroSpeed()
    {
        return aggroSpeed;
    }

    public Color GetAggroColor()
    {
        return aggroColor;
    }
}
