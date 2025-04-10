using UnityEngine;
using UnityEngine.AI;

public class AgentDeplacementScript : MonoBehaviour
{
    public Transform cible;
    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agent.destination = cible.position;
    }
}
