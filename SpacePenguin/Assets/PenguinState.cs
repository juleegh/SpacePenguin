using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct PenguinState
{
    private Vector3 position;
    private Vector3 rotation;
    private float health;

    public PenguinState(Vector3 parameterPos, Vector3 parameterRot, float parameterHealth)
    {
        position = parameterPos;
        rotation = parameterRot;
        health = parameterHealth;
    }

    public Vector3 GetPosition() { return position; }
    public Vector3 GetRotation() { return rotation; }
}
