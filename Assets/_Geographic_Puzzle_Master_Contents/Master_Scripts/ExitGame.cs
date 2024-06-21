using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; 
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    private void Update()
    {
        if(Application.isPlaying)
        { 
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene(0); 
            }
        }
    }
}
