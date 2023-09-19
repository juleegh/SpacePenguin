using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item Properties")]

public class ItemProperties : ScriptableObject
{
    [SerializeField] private float healthIncrease;
    [SerializeField] private float speedIncrease;
    [SerializeField] private float staminaIncrease;
    [SerializeField] private Color colorType;

    public float GetHealthIncrease()
    {
        return healthIncrease;
    }

    public float GetSpeedIncrease()
    {
        return speedIncrease;
    }

    public float GetStaminaIncrease()
    {
        return staminaIncrease;
    }

    public Color GetColorType()
    {
        return colorType;
    }
}
