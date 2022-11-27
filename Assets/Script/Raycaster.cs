using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Raycaster : MonoBehaviour
{
    private Camera cam => Camera.main;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        RaycastHit ray;
        if (InputManager.instance.playerControl.BaseControl.E.triggered)
        {
            if (Physics.Raycast(cam.transform.position,cam.transform.forward, out ray , 5))
            {
                if(ray.transform.TryGetComponent(out RayReciever rayReciever))
                {
                    rayReciever.triggerRay();
                }
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawRay(cam.transform.position,cam.transform.forward * 10);
    }
}
