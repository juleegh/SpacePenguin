using UnityEngine;
using UnityEngine.AI;

public class Pigeon : MonoBehaviour
{
    [SerializeField] private NavMeshAgent navMeshAgent;
    [SerializeField] private MeshRenderer meshRenderer;
    [SerializeField] private EnemyQualities enemyQualities;
    void Start()
    {
        navMeshAgent.speed = enemyQualities.GetRegularSpeed();
        EnemyManager.ThresholdReached += GoAggro;
    }
    void OnDestroy()
    {
        EnemyManager.ThresholdReached -= GoAggro;
    }

    private void GoAggro()
    {
        navMeshAgent.speed = enemyQualities.GetAggroSpeed();
        meshRenderer.material.color = enemyQualities.GetAggroColor();
        EnemyManager.ThresholdReached -= GoAggro;

    }
}
