using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehavior : MonoBehaviour
{
    public Transform destination;

    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        MoveToNextPatrolLocation();
        
    }

    void MoveToNextPatrolLocation() {
        agent.destination = destination.position;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
