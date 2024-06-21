using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial_Event : MonoBehaviour
{
    [SerializeField] private GameObject platformSpawn;
    [SerializeField] private GameObject envIntroPrefab; 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Push"))
        {
            print(collision); 
            Destroy(collision.gameObject);
            Instantiate(platformSpawn);
            Instantiate(envIntroPrefab);
            Destroy(gameObject); 
        }
    }
}
