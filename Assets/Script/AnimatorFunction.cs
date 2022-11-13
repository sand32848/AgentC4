using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AnimatorFunction : MonoBehaviour
{
    [SerializeField] private List<AnimFunction> animFunc = new List<AnimFunction>();
   
    public  void invokeAnimFunction(int index)
    {
        animFunc[index].unityEvent.Invoke();
    }
}

[System.Serializable]
public class AnimFunction
{
    [SerializeField] public string funcName;
    [SerializeField] public UnityEvent unityEvent;
}
