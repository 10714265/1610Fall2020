
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AIBehavior : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform coordinates;
    private bool canPatrol = true;
    private int i = 0;
    
    public List<Transform> patrolpoints;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        coordinates = transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        canPatrol = false;
        coordinates = other.transform;
    }

    private void OnTriggerExit(Collider other)
    {
        canPatrol = true;
    }

    
    
    private void Update()
    {
        agent.destination = coordinates.position;
        if (!canPatrol) return;

        coordinates = patrolpoints[i];
    }
}
