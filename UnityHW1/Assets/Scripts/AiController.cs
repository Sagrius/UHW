using System;
using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;

public class AiController : MonoBehaviour
{
    [SerializeField] private NavMeshAgent navMeshAgent;
    [SerializeField] private Transform pathWaypoint;
    [SerializeField] private GameObject finishedpanel;
    
    private void Start()
    {   
        navMeshAgent.SetDestination(pathWaypoint.position);
    }

    private void Update()
    { 
        
        if (navMeshAgent.remainingDistance <= 0.3f)
        {
            finishedpanel.SetActive(true);
        }
        
    }
}
