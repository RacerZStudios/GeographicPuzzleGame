using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int playerSpeed = 500; 
        if(Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody>().velocity = Vector3.forward * playerSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().velocity = Vector3.left * playerSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody>().velocity = Vector3.back * playerSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().velocity = Vector3.right * playerSpeed * Time.deltaTime;
        }
    }
}
