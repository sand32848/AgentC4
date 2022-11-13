using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class Telescope : MonoBehaviour
{ 
    [SerializeField] private float camSpeed;
    [SerializeField] private GameObject scopeImage;
    private float rangeLimitY = 20;
    private float rangeLimitX = 40;
    private float _rangeLimitX;
    private float _rangeLimit;
    private CinemachineVirtualCamera virtualCamera => GetComponent<CinemachineVirtualCamera>();
    private CinemachineConfiner cinemachineConfiner => GetComponent<CinemachineConfiner>();

    [SerializeField] private float zoomSpeed;
    [SerializeField] private UnityEvent onFoundEvent;
    private bool found = false;

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

        if (InputManager.instance.playerControl.BaseControl.Space.triggered)
        {
            ExitTelescope();
        }

        virtualCamera.m_Lens.OrthographicSize = Mathf.Clamp(virtualCamera.m_Lens.OrthographicSize,5,7);

        if (found) return;


        RaycastHit ray;

        if (Physics.Raycast(transform.position, virtualCamera.transform.forward, out ray, Mathf.Infinity))
        {
            if (ray.transform.name == "Rock6A")
            {
                found = true;
                onFoundEvent.Invoke();
            }  
        }
    }

    public void ExitTelescope()
    {
        virtualCamera.Priority = 0;
        scopeImage.SetActive(false);
    }

    public void EnterTelescope()
    {
        virtualCamera.Priority = 100;
        scopeImage.SetActive(true);
    }
}
