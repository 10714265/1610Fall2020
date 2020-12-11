using System;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class NewAI : MonoBehaviour
{
    private NavMeshAgent buddy;
    public Transform player;

    private void Start()
    {
        buddy = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        buddy.destination = player.position;
    }
}
