using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementCar : MonoBehaviour
{

    [SerializeField] private float accelerationRate;
    [SerializeField] private float decelerationRate;
    [SerializeField] private float gravity;
    [SerializeField] private float maxVerticalSpeed;
    [SerializeField] private float maxHorizontalSpeed;
    private float currentSpeed;
    private Vector3 calSpeed;
    private InputManager inputManager;
    private Rigidbody rb;
    private CharacterController characterController => GetComponent<CharacterController>();
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
            //currentSpeed += (moveSpeed) * Time.deltaTime;
            //currentSpeed = Mathf.Clamp(currentSpeed, 0, maxSpeed);
        }
        else
        {
            currentSpeed -= decelerationRate;
            currentSpeed = Mathf.Clamp(currentSpeed, 0, 100000);
        }

        calSpeed = currentSpeed * dir;
        characterController.Move(new Vector3(calSpeed.x, -gravity, calSpeed.z) * Time.deltaTime);
    }
}
