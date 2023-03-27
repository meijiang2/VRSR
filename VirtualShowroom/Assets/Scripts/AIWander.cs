using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIWander : MonoBehaviour
{
    private float destinationDistance;
    private float wanderRange;
    private Vector3 newPos;
    private NavMeshAgent thisAgent = null;

    void Awake()
    {
        destinationDistance = 5f;
        wanderRange = 40f;
        thisAgent = GetComponent<NavMeshAgent>();
        newPos = RandomPosition();
    }

    void Update()
    {
        thisAgent.SetDestination(newPos);
        if (Vector3.Distance(transform.position, newPos) < destinationDistance)
        {
            newPos = RandomPosition();
        }
    }

    public Vector3 RandomPosition()
    {
        Vector3 randomPos = Random.insideUnitSphere * wanderRange;
        randomPos += transform.position;
        Vector3 finalPos = Vector3.zero;
        if (NavMesh.SamplePosition(randomPos, out NavMeshHit hit, wanderRange, thisAgent.areaMask))
        {
            finalPos = hit.position;
        }
        return finalPos;
    }
}
