using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singing : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            RaycastHit hit;
            bool result = Physics.Raycast(transform.position, transform.forward, out hit, 5);
        
            if(result)
            {
                Health health = hit.collider.GetComponent<Health>();
                if (health != null)
                {
                    health.TakeDamage(50);
                }
            }
        }
    }
}
