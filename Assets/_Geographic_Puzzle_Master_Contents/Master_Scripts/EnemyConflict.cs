using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyConflict : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private NavMeshAgent agent;

    private void Start()
    {
        if(target == null)
        {
            return; 
        }
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if(target != null && target.gameObject.activeInHierarchy)
        {
            agent.SetDestination(target.gameObject.transform.position);
            agent.transform.LookAt(target.gameObject.transform);
            if (target.gameObject.transform != null)
            {
                target = GameObject.FindGameObjectWithTag("Player");
            }

            agent.transform.position = gameObject.transform.position;
            return; 
        }
    }
}
