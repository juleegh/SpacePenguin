using UnityEngine;

public class Soul : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Health health = other.GetComponent<Health>();
        if (health != null)
        {
            health.IncreaseHealth(5);
            Destroy(gameObject);
        }
    }
}
