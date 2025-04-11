using UnityEngine;
using UnityEngine.AI;

public class AgentDeplacementScript : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform cible;
    public Transform spawnPoint;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agent.destination = cible.position;

        if (Vector3.Distance(cible.position ,gameObject.transform.position) <= 1.5)
        {
            GameObject.Find("Main Camera").GetComponent<PlayerController>().PlayerHit();
            transform.position = spawnPoint.position;
        }
    }
}
