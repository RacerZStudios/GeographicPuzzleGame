using System.Collections;
using System.Collections.Generic;
using TMPro; 
using UnityEngine;

public class CollectedLetterManager : MonoBehaviour
{
    [Header("Region A")]
    [SerializeField] private string A; 
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

    private void Start()
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
                print(ALetter); 
            }
            // Letter A has been found
            print("Letter A discovered");
            print(RockText + "Enter"); 
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
            if (AText == null || ALetter == false)
            {
                GameObject.Find("ArizonaText").GetComponent<TextMeshProUGUI>().enabled = true; 
                print(AText);
            }
            Destroy(gameObject, 3);
        }
    }
}