using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial_Event : MonoBehaviour
{
    [SerializeField] private GameObject platformSpawn;
    [SerializeField] private GameObject envIntroPrefab;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip audioClip;
    [SerializeField] private AudioClip audioClipPrefab; // desert rock prefab audio
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Push"))
        {
            print(collision);
            audioSource.PlayOneShot(audioClip);
            Destroy(collision.gameObject, audioClip.length);
            Instantiate(platformSpawn);
            Instantiate(envIntroPrefab);
            audioSource.PlayOneShot(audioClipPrefab); 
            Destroy(gameObject, audioClipPrefab.length); 
        }
    }
}
