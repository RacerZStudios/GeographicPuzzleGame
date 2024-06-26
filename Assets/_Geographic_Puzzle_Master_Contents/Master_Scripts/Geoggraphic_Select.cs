using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Geoggraphic_Select : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip audioClip; 
    private void LoadGeoRegion1()
    {
        audioSource.clip = audioClip;
        audioSource.PlayOneShot(audioSource.clip);
        SceneManager.LoadScene(1); 
    }
}
