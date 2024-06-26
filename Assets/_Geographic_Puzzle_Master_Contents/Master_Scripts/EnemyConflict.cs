using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyConflict : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private PlayerHealth playerHealth;
    [SerializeField] private int enemyHealth;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip audioClip; // attack audio
    [SerializeField] private AudioClip audioClip2; // player hurt audio 

    private void Awake()
    {
        if(target == null)
        {
            target = GameObject.Find("Player");
            target = GetComponent<GameObject>();
            return; 
        }

        if(playerHealth == null)
        {
            playerHealth = FindObjectOfType<PlayerHealth>();
            playerHealth = GetComponent<PlayerHealth>();
            return; 
        }
    }
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
        if(target == null || playerHealth == null)
        {
            target = FindObjectOfType<GameObject>();
            playerHealth = FindObjectOfType<PlayerHealth>(); 
        }
        else if(!target.activeInHierarchy || !playerHealth)
        {
            return; 
        }
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

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Push"))
        {
            enemyHealth--;
            audioSource.PlayOneShot(audioClip);
            if (enemyHealth <= 0)
            {
                // set dead animation 
                Destroy(gameObject);
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision != null)
        {
            if (collision.gameObject.activeInHierarchy && collision.gameObject.CompareTag("Player"))
            {
                // play hurt audioClip 
                audioSource.PlayOneShot(audioClip2);
                playerHealth.Health();
                return;
            }
        }
    }
}
