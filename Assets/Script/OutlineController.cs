using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineController : MonoBehaviour
{
    //private Camera camera;
    //private Outline currentOutline;
    //[SerializeField] private LayerMask ignoreLayer;

    //private void Start()
    //{
    //    camera = Camera.main;
    //}

    //void Update()
    //{
    //    //OutLine Check
    //    RaycastHit OutlineHit;
    //    if (Physics.Raycast(camera.transform.position, camera.transform.forward, out OutlineHit, Mathf.Infinity, ignoreLayer))
    //    {
    //        if (OutlineHit.transform.TryGetComponent(out Outline outline))
    //        {
    //            if (currentOutline == outline) return;
    //            else if (currentOutline != null && currentOutline.mark)
    //            {
    //                currentOutline = null;
    //                currentOutline = outline;
    //                currentOutline.SetThickness(10);
    //            }
    //            else
    //            {
    //                currentOutline?.SetThickness(0);
    //                currentOutline = null;
    //                currentOutline = outline;
    //                currentOutline.SetThickness(10);
    //            }
              
    //        }
    //        else
    //        {
    //            if (currentOutline != null && currentOutline.mark)
    //            {
    //                currentOutline = null;
    //                return;
    //            }
    //            currentOutline?.SetThickness(0);
    //            currentOutline = null;
    //        }
    //    }
    //    else
    //    {
    //        if (currentOutline != null && currentOutline.mark)
    //        {
    //            currentOutline = null;
    //            return;
    //        }
    //        currentOutline?.SetThickness(0);
    //        currentOutline = null;
    //    }
    //}
}
