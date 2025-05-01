using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterMovement : MonoBehaviour






{
    public float verticalSpeed = 1f;

    public float horizontalSpeed = 1f;

    private CharacterController  controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(Input.GetAxis("Vertical")* horizontalSpeed * Time.deltaTime,
            0f,
            Input.GetAxis("Horizontal") * verticalSpeed * Time.deltaTime);
        
        controller.Move(direction);
    }
}
