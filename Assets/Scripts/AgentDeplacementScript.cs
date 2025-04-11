using System;
using UnityEngine;
using UnityEngine.AI;

public class AgentDeplacementScript : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform cible;
    public Transform spawnPoint;

    public PlayerController playerController;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agent.destination = cible.position;

        if (Vector3.Distance(cible.position ,gameObject.transform.position) <= 1.5)
        {
            playerController.StartCoroutinePlayerHit();
            transform.position = spawnPoint.position;
        }
    }
}
