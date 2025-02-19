using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Respawn : MonoBehaviour
{
    private Vector3 spawnPos;
    private NavMeshAgent agent;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPos = transform.position;
        agent = GetComponent<NavMeshAgent>();
    }

    private void DoRespawn()
    {
        agent.ResetPath();
        transform.position = spawnPos;
    }

    private void OnCollisionEnter(Collision collision)
    {
        DoRespawn();
    }
}
