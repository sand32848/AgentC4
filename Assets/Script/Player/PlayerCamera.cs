using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private float mouseSensitivity;
    private CinemachineVirtualCamera camera;
    private Transform playerTransform;

    float xRotation = 0;
    private void Awake()
    {
        playerTransform = GetComponent<Transform>();
        camera = GetComponentInChildren<CinemachineVirtualCamera>();
        Cursor.lockState = CursorLockMode.Locked;
    }


    // Update is called once per frame
    void Update()
    {
        float mouseX = InputManager.instance.playerControl.BaseControl.Mouse.ReadValue<Vector2>().x * mouseSensitivity * Time.deltaTime;
        float mouseY = InputManager.instance.playerControl.BaseControl.Mouse.ReadValue<Vector2>().y * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation,-90,90f);

        camera.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerTransform.Rotate(Vector3.up * mouseX);
    }
}
