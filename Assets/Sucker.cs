using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sucker : MonoBehaviour
{
    [SerializeField] private List<Rigidbody> objectToSuck = new List<Rigidbody>();
    [SerializeField] private bool allowSuck;
    [SerializeField] private float suckForce;
    private void Update()
    {
        if (!allowSuck) return;

        foreach(Rigidbody rb in objectToSuck)
        {
            rb.AddForce((transform.position - rb.transform.position ).normalized * suckForce);
        }
    }

    public void turnOnSuck()
    {
        allowSuck = true;
    }
}
