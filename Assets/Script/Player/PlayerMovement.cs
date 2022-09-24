using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float accelerationRate;
    [SerializeField] private float maxSpeed;
    [SerializeField] private float decelerationRate;
    private float currentSpeed;
    private Vector3 calSpeed;
    private InputManager inputManager;
    private Rigidbody rb;
    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
       Vector2 movementDir = inputManager.playerControl.BaseControl.Movement.ReadValue<Vector2>();
       Vector3 dir = transform.right * movementDir.x + transform.forward * movementDir.y;

        if (dir != Vector3.zero)
        {
            currentSpeed += (moveSpeed) * Time.deltaTime ;
            currentSpeed = Mathf.Clamp(currentSpeed,0, maxSpeed);
        }
        else
        {
            currentSpeed -= decelerationRate;
            currentSpeed = Mathf.Clamp(currentSpeed, 0, 100000);
        }

        calSpeed = currentSpeed * dir;
        rb.velocity = new Vector3(calSpeed.x,0, calSpeed.z);
    }
    
    public void stopMove()
    {
        rb.velocity = Vector3.zero;
    }


}
