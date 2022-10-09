using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Raycaster : MonoBehaviour
{
    private Camera cam => Camera.main;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit ray;
        if (InputManager.instance.playerControl.BaseControl.E.triggered)
        {
            if (Physics.Raycast(cam.transform.position,cam.transform.forward, out ray))
            {
                if(ray.transform.TryGetComponent(out RayReciever rayReciever))
                {
                    rayReciever.triggerRay();
                }
            }
        }
    }
}
