using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI; 
using UnityEngine;

public class BasicMoveMouseClick : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private RaycastHit hit;
    [SerializeField] private NavMeshAgent playerAgent;
    [SerializeField] LayerMask ground; 

    private void Start()
    {
        playerAgent = GetComponentInChildren<NavMeshAgent>();
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit, Mathf.Infinity, ground))
            {
                if(hit.collider != null)
                {
                    playerAgent.SetDestination(hit.point); 
                }
            }
        }
    }
}
