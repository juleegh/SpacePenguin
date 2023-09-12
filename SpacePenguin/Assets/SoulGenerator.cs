using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulGenerator : MonoBehaviour
{
    [SerializeField] private GameObject soulPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Vector3 randomPosition = new Vector3(Random.Range(-10, 10), 1, Random.Range(-10, 10));
            Instantiate(soulPrefab, randomPosition, Quaternion.identity);
        }
    }
}
