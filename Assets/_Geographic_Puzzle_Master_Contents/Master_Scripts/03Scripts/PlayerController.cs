using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce;
    public CharacterController characterController;
    
    
    [SerializeField] private float gravityScale = 3f;
    [SerializeField] private float gravity = -9.81f;
    [SerializeField] private bool facingRight = true;
    [SerializeField] private float moveDirectionX;
    [SerializeField] private float moveDirectionZ;
    [SerializeField] private bool isGrounded;
    
    private Vector3 _moveDirection;
    [SerializeField] private float _velocity;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        if(!facingRight)
        {
            facingRight = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        //Gravity
        _velocity += gravity * gravityScale * Time.deltaTime;
        
        _moveDirection.y = _velocity;
        
        
        //Ground movement
        moveDirectionX = Input.GetAxisRaw("Horizontal");
        moveDirectionZ = Input.GetAxisRaw("Vertical");
        _moveDirection = new Vector3(moveDirectionX , 0f, moveDirectionZ);
        _moveDirection = _moveDirection * moveSpeed;
        
        
        //Jumping
        if (Input.GetButtonDown("Jump"))
        {
            _moveDirection.y = jumpForce;
            
        }

       
       
        
        //transform.position = transform.position + (_moveDirection * Time.deltaTime * moveSpeed);
        characterController.Move(_moveDirection * Time.deltaTime);



    }
    
    
}
