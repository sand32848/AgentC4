using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Counter : MonoBehaviour
{
    [SerializeField] private float counterTarget;
    [SerializeField] private float currentTarget;
    [SerializeField] private UnityEvent onReachCounterEvent;


    public void increaseCounter(float _counter)
    {
        currentTarget += _counter;

        if (currentTarget >= counterTarget)
        {
            onReachCounterEvent.Invoke();
        }
    }

    public void decreaseCounter(float _counter)
    {
        currentTarget -= _counter;

  
    }

    
}
