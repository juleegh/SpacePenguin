using UnityEngine;

public class FacePlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 eulerAngles = transform.eulerAngles;
        transform.LookAt(player.transform.position);
        eulerAngles.y = transform.eulerAngles.y;
        transform.eulerAngles = eulerAngles;
    }
}
