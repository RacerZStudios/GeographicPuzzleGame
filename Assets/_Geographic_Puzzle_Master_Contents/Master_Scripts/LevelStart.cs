using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LevelStart : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip audioClip; 
    private void StartLevel()
    {
        player.SetActive(true);
    }

    private void EndSelect()
    {
        audioSource.PlayOneShot(audioClip);
        gameObject.SetActive(false); 
    }
}
