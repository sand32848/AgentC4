using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telescope : MonoBehaviour
{ 
    [SerializeField] private float camSpeed;
    private float rangeLimitY = 20;
    private float rangeLimitX = 40;
    private float _rangeLimitX;
    private float _rangeLimit;
    private CinemachineVirtualCamera virtualCamera => GetComponent<CinemachineVirtualCamera>();
    private CinemachineConfiner cinemachineConfiner => GetComponent<CinemachineConfiner>();

    [SerializeField] private float zoomSpeed;

    void Update()
    {
        Vector2 v = InputManager.instance.playerControl.BaseControl.Movement.ReadValue<Vector2>();

        virtualCamera.transform.position += new Vector3(-v.x * camSpeed, 0, v.y * camSpeed) * Time.deltaTime;

        if (InputManager.instance.playerControl.BaseControl.E.IsPressed())
        {
            virtualCamera.m_Lens.OrthographicSize -= Time.deltaTime * zoomSpeed;
        }

        if (InputManager.instance.playerControl.BaseControl.Q.IsPressed())
        {
            virtualCamera.m_Lens.OrthographicSize += Time.deltaTime * zoomSpeed;
        }


        virtualCamera.m_Lens.OrthographicSize = Mathf.Clamp(virtualCamera.m_Lens.OrthographicSize,5,7);

    }

    public void ExitTelescope()
    {

    }

    public void EnterTelescope()
    {

    }
}
