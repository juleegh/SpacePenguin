using System.Collections.Generic;
using UnityEngine;

public class PenguinTimeTravel : MonoBehaviour
{
    List<PenguinState> saveStates;

    private void Start()
    {
        saveStates = new List<PenguinState>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            float currentHealth = GetComponent<Health>().GetCurrentHealth();
            PenguinState penguinState = new PenguinState(transform.position, transform.eulerAngles, currentHealth);
            saveStates.Add(penguinState);
        }

        if (Input.GetKeyDown(KeyCode.W) && saveStates.Count > 0)
        {
            PenguinState penguinState = saveStates[saveStates.Count - 1];
            transform.position = penguinState.GetPosition();
            transform.eulerAngles = penguinState.GetRotation();
        }
    }
}
