using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public static Action onTargetComplete;

    public  void invokeEliminiate()
    {
        onTargetComplete?.Invoke();
    }
}
