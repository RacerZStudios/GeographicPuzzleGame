using System.Collections;
using System.Collections.Generic;
using TMPro; 
using UnityEngine;

public class RiddleManager : MonoBehaviour
{
    [SerializeField] private GameObject AText;
    [SerializeField] private TextMeshProUGUI aTextActive; 
    [SerializeField] public static bool A;
    
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

        if(aTextActive != null || AText.activeInHierarchy)
        {
            AText.gameObject.GetComponent<TextMeshProUGUI>();
            aTextActive.text.Equals(true); 
        }
        else
        {
            if(aTextActive == null)
            {
                return; 
            }
        }
    }

    private void ALevelComplete()
    {
        print("A Level Completed"); 
    }
}