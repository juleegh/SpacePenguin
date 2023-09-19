using UnityEngine;

public class Soul : MonoBehaviour
{
    [SerializeField] private ItemProperties properties;

    private void Start()
    {
        GetComponent<MeshRenderer>().material.color = properties.GetColorType();
    }
    private void OnTriggerEnter(Collider other)
    {
        Health health = other.GetComponent<Health>();
        if (health != null)
        {
            health.IncreaseHealth(properties.GetHealthIncrease());
        }
        PenguinMovement movement = other.GetComponent<PenguinMovement>();
        if(movement != null)
        {
            movement.ModifySpeed(properties.GetSpeedIncrease());
        }
        Destroy(gameObject);
    }
}
