using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RayReciever : MonoBehaviour
{
    public UnityEvent onRay;

    public void triggerRay()
    {
        onRay.Invoke();
    }
}
