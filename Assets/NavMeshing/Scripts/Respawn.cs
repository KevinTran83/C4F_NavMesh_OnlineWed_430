using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Respawn : MonoBehaviour
{
    private Vector3 spawnPos;
    private NavMeshAgent agent;
    private ScoreManager sm;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPos = transform.position;
        agent = GetComponent<NavMeshAgent>();
        sm = FindFirstObjectByType<ScoreManager>();
    }

    private void DoRespawn()
    {
        agent.ResetPath();
        transform.position = spawnPos;
        sm.ResetScore();
    }

    private void OnCollisionEnter(Collision collision)
    {
        DoRespawn();
    }
}
