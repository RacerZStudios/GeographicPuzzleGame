using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCue : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip audioClip;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Env"))
        {
            audioSource.PlayOneShot(audioClip);
        }
    }
}
