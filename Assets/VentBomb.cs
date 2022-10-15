using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VentBomb : MonoBehaviour
{
    private bool ready = false;
    public UnityEvent explodeEvent;

    private void Update()
    {
        if (!ready) return;
        if (InputManager.instance.playerControl.BaseControl.RightClick.triggered)
        {
            explodeEvent.Invoke();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            Destroy(other.gameObject);

            ready = true;
        }
    }

}
