using UnityEngine;
using UnityEngine.AI;

public class PigeonPatrol : MonoBehaviour
{
    [SerializeField] private NavMeshAgent pigeonAgent;
    [SerializeField] private Transform position1;
    [SerializeField] private Transform position2;

    private Vector3 currentTarget;
    void Start()
    {
        pigeonAgent.SetDestination(position1.position);
        currentTarget = position1.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (pigeonAgent.remainingDistance < 0.35f)
        {
            if (currentTarget == position1.position)
            {
                currentTarget = position2.position;
            }
            else
            {
                currentTarget = position1.position;
            }
            pigeonAgent.SetDestination(currentTarget);
        }
    }
}
