using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private static PlayerHealth playerHealth;
    [SerializeField] private int health; 

    public int Health()
    {
        health -= 1;
        print(health);
        return health; 
    }

    private void Update()
    {
        if(health <= 0)
        {
            health = 0; 
            Destroy(gameObject);
        }
    }
}
