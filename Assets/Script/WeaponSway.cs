using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSway : MonoBehaviour
{
    [SerializeField] private float smooth;
    [SerializeField] private float swayMulti;
    [SerializeField] private Transform gunPoint;

    private void Update()
    {
        float mouseX = InputManager.instance.playerControl.BaseControl.Mouse.ReadValue<Vector2>().x * swayMulti;
        float mouseY = InputManager.instance.playerControl.BaseControl.Mouse.ReadValue<Vector2>().y *  swayMulti;

        Quaternion rotationX = Quaternion.AngleAxis(-mouseY, Vector3.right);
        Quaternion rotationY = Quaternion.AngleAxis(mouseX, Vector3.up);

        Quaternion targetRotation = rotationX * rotationY;

        gunPoint.localRotation = Quaternion.Slerp(gunPoint.localRotation,targetRotation,smooth * Time.deltaTime);
    }
}
