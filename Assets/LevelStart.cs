using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LevelStart : MonoBehaviour
{
    [SerializeField] private GameObject player; 
    private void StartLevel()
    {
        player.SetActive(true);
    }

    private void EndSelect()
    {
        gameObject.SetActive(false); 
    }
}
