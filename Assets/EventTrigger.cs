using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventTrigger : MonoBehaviour
{
    [SerializeField] private UnityEvent EventList;

    public void TriggerEvent()
    {
        EventList.Invoke();
    }
}
