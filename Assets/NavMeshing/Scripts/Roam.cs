using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Roam : MonoBehaviour
{
    public float range = 10.0f;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        PickNewDestination();
    }

    void PickNewDestination()
    {
        Vector3 dest = transform.position + Random.insideUnitSphere * range;

        NavMeshHit hit;
        if (NavMesh.SamplePosition(dest, out hit, 1, NavMesh.AllAreas)) agent.SetDestination(dest);
        else PickNewDestination();
    }
}
