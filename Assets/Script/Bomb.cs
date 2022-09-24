using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    Rigidbody rb => transform.GetComponent<Rigidbody>();
    [SerializeField] private float range;
    [SerializeField] private float explosionForce;
    [SerializeField] private LayerMask hitLayer;
  
    public void explode()
    {
        Collider[] explodeHit = Physics.OverlapSphere(transform.position, range, LayerMask.GetMask("Explodable")) ;

       for(int i =0; i < explodeHit.Length; i++)
        {
            if (explodeHit[i].TryGetComponent(out Explodable explode))
            {
                explode.onExplode();
            }
        }
       
    }

    public void addForce(Vector3  force)
    {
        rb.AddForce(force,ForceMode.Impulse);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position,range);
    }
}
