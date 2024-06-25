using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedLetterManager : MonoBehaviour
{
    [SerializeField] private GameObject canvas; 
    [SerializeField] private GameObject RockText;
    [SerializeField] private GameObject AText;
    [SerializeField] private bool ALetter = true;

    private void Awake()
    {
        if(AText == null)
        {
            AText = FindObjectOfType<GameObject>();
        }
        else if(AText.GetComponent<GameObject>() != null)
        {
            return; 
        }
    }

    private void Update()
    {
        if (canvas == null)
        {
            canvas = GameObject.Find("TextCanvas"); // no need for GetCompoennt() here with GameObject.Find()
        }

        if (RockText == null)
        {
            RockText = GameObject.Find("RocksFormText");
        }
        if (AText == null || ALetter == false)
        {
            AText = GameObject.Find("ArizonaText");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Push"))
        {
            if(ALetter != false)
            {
                ALetter = false; 
            }
            // Letter A has been found
            print("Letter A discovered");
            print(RockText + "Enter"); // should be off here 
            if (AText == null)
            {
                AText = FindObjectOfType<GameObject>();
                AText.SetActive(true);
                return;
            }
            print(AText);
            if(ALetter == false)
            {
                AText.SetActive(true);
                return; 
            }
            return; 
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Push") && ALetter == false)
        {
            canvas.SetActive(true);
            print(canvas); 
            RockText.SetActive(false);
            print(RockText + "Exit");
   
            Destroy(gameObject, 3);
        }
    }
}