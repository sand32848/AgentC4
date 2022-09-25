using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.Events;

public class Explodable : MonoBehaviour
{
    [SerializeField] private bool pieces;
    [SerializeField] private bool NPC;

    [ShowIf("pieces")]
    [SerializeField] private UnfreezeFragment unfreezeFragment;

    [SerializeField] private UnityEvent oneTimeExplodeEvent;
    [SerializeField] private UnityEvent explodeEvent;

    private bool firstimeExplode;

    private Renderer renderer;
    private Animator animator;
    private Rigidbody rb;
    private Collider[] colliderArray => GetComponentsInChildren<Collider>();
    private Rigidbody[] rigidArray => GetComponentsInChildren<Rigidbody>();
    private CharacterJoint[] jointArray => GetComponentsInChildren<CharacterJoint>();

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        renderer = GetComponentInChildren<Renderer>();
        animator = GetComponent<Animator>();

        if (NPC)
        {
            disableCollider();
            foreach (Rigidbody rb in rigidArray)
            {
                rb.collisionDetectionMode = CollisionDetectionMode.Continuous;
            }

        }


        foreach (CharacterJoint joint in jointArray)
        {
            joint.enableProjection = true;
        }

        transform.GetComponent<Collider>().enabled = true;
    }

    public void onExplode()
    {
        if (pieces)
        {
            unfreezeFragment?.Unfreeze();

            if(renderer) renderer.enabled = false;
        }
 
        if (!firstimeExplode)
        {
            oneTimeExplodeEvent?.Invoke();
            firstimeExplode = true;
        }

        explodeEvent?.Invoke();
    }

    public void enableCollider()
    {
        foreach(Collider i in colliderArray)
        {
            i.enabled = true;
        }
    }

    public void disableCollider()
    {
        foreach (Collider i in colliderArray)
        {
            i.enabled = false;
        }
    }

    public Rigidbody[] rigidList()
    {
        return rigidArray;
    }
}
