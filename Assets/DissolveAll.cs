using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveAll : MonoBehaviour
{
    public static Action dissolveAll;
    private void Update()
    {
        
    }

    public  void DissolveEnable()
    {
        dissolveAll?.Invoke();
    }
}
