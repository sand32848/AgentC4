using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    private Camera camera;
    [SerializeField] float grabDistance = 10f;
    [SerializeField] float throwForce = 20f;
    [SerializeField] float lerpSpeed = 10f;
    private InputManager inputManager;
    [SerializeField]private Transform objectHolder;

    private Rigidbody rb;

    private void Start()
    {
        inputManager = GetComponent<InputManager>();
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (rb)
        {
            rb.MovePosition(objectHolder.transform.position);
        }


        if (inputManager.playerControl.BaseControl.E.triggered)
        {
            if (rb)
            {
                rb.isKinematic = false;
                rb = null;
            }
            else
            {
                RaycastHit hit;
                Ray ray = camera.ViewportPointToRay(new Vector3(0.5f, 0.5f));
                if(Physics.Raycast(ray,out hit, grabDistance))
                {
                    rb = hit.collider.gameObject.GetComponent<Rigidbody>();
                    if (rb)
                    {
                        rb.isKinematic = true;
                    }
                }
            }
        }
    }
}
