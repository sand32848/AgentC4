using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    Rigidbody rb => transform.GetComponent<Rigidbody>();
    [SerializeField] private float range;
    [SerializeField] private float explosionForce;
    [SerializeField] private GameObject particle;
    [SerializeField] private List<AudioSource> audioSources = new List<AudioSource>();
    [SerializeField] private Renderer renderer;
    private Collider collider;

    private void Start()
    {
        collider = GetComponent<Collider>();
        audioSources = GetComponentsInChildren<AudioSource>().ToList();
    }

    public void addForce(Vector3  force)
    {
        rb.AddForce(force,ForceMode.Impulse);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position,range);
    }

    private void OnCollisionEnter(Collision collision)
    {
        transform.parent = collision.transform;
        //print(collision.transform.name);
        //// creates joint
        //FixedJoint joint = null;

        //if (!GetComponentInChildren<FixedJoint>())
        //{
        //    joint = gameObject.AddComponent<FixedJoint>();
        //}
       
        //// sets joint position to point of contact
        //joint.anchor = collision.contacts[0].point;
        //// conects the joint to the other object
        //joint.connectedBody = collision.contacts[0].otherCollider.transform.GetComponentInParent<Rigidbody>();
        //// Stops objects from continuing to collide and creating more joints
        //joint.enableCollision = false;

        collider.enabled = false;
        rb.useGravity = false;
        rb.mass = 0;
        rb.velocity = Vector3.zero;
        rb.constraints = RigidbodyConstraints.FreezeRotation;
    }

    IEnumerator explode()
    {
        Destroy(Instantiate(particle, transform.position, Quaternion.identity), 3f);

        audioSources[Random.Range(0, audioSources.Count)].Play();

        Collider[] explodeHit = Physics.OverlapSphere(transform.position, range, LayerMask.GetMask("Explodable"));

        for (int i = 0; i < explodeHit.Length; i++)
        {
            if (explodeHit[i].TryGetComponent(out Animator animator))
            {
                animator.enabled = false;
            }

            if (explodeHit[i].TryGetComponent(out Explodable explode))
            {
                explode.enableCollider();
            }
        }

        yield return new WaitForSeconds(0.1f);

        Collider[] explodeHit2 = Physics.OverlapSphere(transform.position, range, LayerMask.GetMask("Explodable"));
        for (int i = 0; i < explodeHit2.Length; i++)
        {
            if (explodeHit2[i].TryGetComponent(out Explodable explode))
            {
                explode.onExplode();

            }

            if (explodeHit2[i].TryGetComponent(out Rigidbody rb))
            {
                rb.AddExplosionForce(explosionForce, transform.position, range, 1f, ForceMode.Impulse);

            }
            //foreach (Rigidbody rb in explode.GetComponent<Rigidbody>())
            //{
            //    rb.AddExplosionForce(explosionForce, transform.position, range, 0.5f, ForceMode.Impulse);
            //}
        }

        renderer.enabled = false;
        Destroy(gameObject,2);
    }
        
}
