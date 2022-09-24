using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static InputManager instance;

    public Control playerControl { get; private set;}
    public PlayerInput playerInput { get; private set; }

    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }

        playerInput = GetComponent<PlayerInput>();
        
        playerControl = new Control();
        playerControl.BaseControl.Enable();
    }
}
