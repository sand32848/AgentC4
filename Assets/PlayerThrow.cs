using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerThrow : MonoBehaviour
{
    [SerializeField] private Rigidbody c4;
    [SerializeField] private float throwForce;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (InputManager.instance.playerControl.BaseControl.LeftClick.triggered)
        {
           Rigidbody c = Instantiate(c4,transform.position,Quaternion.identity);
            c.AddForce(Camera.main.transform.forward * throwForce,ForceMode.Impulse);

        }
    }
}
