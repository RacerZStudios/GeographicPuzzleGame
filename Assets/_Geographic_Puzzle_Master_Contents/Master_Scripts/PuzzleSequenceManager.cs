using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleSequenceManager : MonoBehaviour
{
    [SerializeField] private GameObject platformSpawn;
    [SerializeField] private GameObject envIntroPrefab;
    [SerializeField] private GameObject textPrompt1;
    [SerializeField] private AudioClip audioClip;
    [SerializeField] private AudioSource audioSource; 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Push"))
        {
            print(collision);
            audioSource.PlayOneShot(audioClip);
            Destroy(collision.gameObject, audioClip.length);
            Instantiate(platformSpawn);
            Instantiate(envIntroPrefab);
            Destroy(gameObject);
            textPrompt1.gameObject.SetActive(true); 
        }
    }
}
