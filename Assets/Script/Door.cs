using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Door : MonoBehaviour
{
    private Animator animator => GetComponent<Animator>();
    [SerializeField] private UnityEvent onLeave;
    private bool oneTime;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag != "Player") return;
        animator.Play("OpenPermanent");
    }

    private void OnTriggerExit(Collider other)
    {
        
        if (other.transform.tag != "Player") return;
        animator.Play("door_2_close");

        if (oneTime) return;
        onLeave.Invoke();

        oneTime = true;
    }
}
