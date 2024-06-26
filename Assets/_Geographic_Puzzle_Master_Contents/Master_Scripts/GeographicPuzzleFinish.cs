using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeographicPuzzleFinish : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip audioClip;
    [SerializeField] private GameObject envACompletePrefab;
    [SerializeField] private GameObject CompletePuzzleA;
    [SerializeField] private GameObject letterAActive;
    [SerializeField] private CollectedLetterManager letterManager;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Push"))
        {
            if(!letterAActive.activeInHierarchy || letterManager.gameObject.activeInHierarchy)
            {
                letterManager = FindObjectOfType<CollectedLetterManager>();
                if (letterManager != null)
                {
                    letterManager.ALetter = false;
                }
                else if (letterManager == null)
                {
                    return;
                }          
            }

            if (letterManager.ALetter == false)
            {
                print(collision);
                audioSource.clip = audioClip;
                audioSource.PlayOneShot(audioSource.clip);
                Instantiate(envACompletePrefab);
                CompletePuzzleA.SetActive(true);
                Destroy(collision.gameObject, audioClip.length);
            }
        }
        return; 
    }

    private void FinishRegion1()
    {
        if(CompletePuzzleA != null)
        {
            SceneManager.LoadSceneAsync(0);
        }
    }
}
