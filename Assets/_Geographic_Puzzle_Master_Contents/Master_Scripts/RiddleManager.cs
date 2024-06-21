using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiddleManager : MonoBehaviour
{
    [SerializeField] private GameObject AText;
    [SerializeField] private bool A = false;

    private void Awake()
    {
        if(!A)
        {
            A = true;
        }

        if(AText != null)
        {
            A = true;
            return; 
        }
    }

    private void Start()
    {
        if(AText != null)
        {
            AText = GameObject.Find(AText.name);
        }
        else if(AText == null)
        {
            return; 
        }
    }

    private void Update()
    {
        if(AText == null)
        {
            A = true; 
            return; 
        }

        if(AText == null && AText.activeInHierarchy)
        {
            AText = GameObject.Find(AText.activeInHierarchy.ToString());
            return; 
        }
    }
}
