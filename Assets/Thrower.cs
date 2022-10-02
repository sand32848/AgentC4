using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrower : MonoBehaviour
{
    [MinValue(-1)]
    [MaxValue(1)]
    [SerializeField] private float throwDirXMin,throwDirXMax;
    [MinValue(-1)]
    [MaxValue(1)]
    [SerializeField] private float throwDirYMin,throwDirYMax;
    [SerializeField] private float throwForce;
    [SerializeField] private float throwUp;
    [SerializeField] private Rigidbody throwTarget;

    private void Update()
    {
        if (InputManager.instance.playerControl.BaseControl.E.triggered)
        {
            Throw();
        }
    }

    public void Throw()
    {
       Rigidbody rb = Instantiate(throwTarget,transform.position,Quaternion.identity);
        rb.AddForce(new Vector3(Random.Range(throwDirXMin,throwDirXMax),0, Random.Range(throwDirYMin, throwDirYMax)) * throwForce + Vector3.up * throwUp,ForceMode.Impulse);

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawRay(transform.position, new Vector3(throwDirXMax, 0, throwDirYMax).normalized * 10);
        Gizmos.DrawRay(transform.position, new Vector3(throwDirXMin, 0, throwDirYMin).normalized * 10);
    }
}
