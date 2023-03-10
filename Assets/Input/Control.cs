//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.2
//     from Assets/Input/Control.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Control : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Control()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Control"",
    ""maps"": [
        {
            ""name"": ""BaseControl"",
            ""id"": ""f7919704-1576-4c49-896a-fda94b016355"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""4e6fb042-07ce-4382-aab8-64d47e81a5e5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Escape"",
                    ""type"": ""Button"",
                    ""id"": ""9b57aac9-c9f9-4453-853d-a064225edb89"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""R"",
                    ""type"": ""Button"",
                    ""id"": ""c3d04a73-edf7-43e6-ad2f-050b8a000c18"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Mouse"",
                    ""type"": ""Value"",
                    ""id"": ""652bf1dc-dd15-4ca2-885d-2817ce853f8c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""E"",
                    ""type"": ""Button"",
                    ""id"": ""1748e633-f43b-4e71-be55-7dcaf3f077ae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeftClick"",
                    ""type"": ""Button"",
                    ""id"": ""a4812043-ad43-45ba-b879-f63ab0722c75"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""Button"",
                    ""id"": ""8f351087-79e8-4eb6-b03a-bd672687d9f8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Q"",
                    ""type"": ""Button"",
                    ""id"": ""d877cc0b-81bf-4b9a-8ad8-835a0f6d4724"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Space"",
                    ""type"": ""Button"",
                    ""id"": ""ab8816d9-a9fe-4462-b0f9-7f78f3b4d29f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""ed43963e-cc55-44a6-9c98-ef94f99b32f2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c452a1d1-22fc-4f42-9094-7dd19ece329c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""937839d5-c3b9-4109-84db-0371f671483b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ec7369be-bd78-49d1-b1e6-157b5c4f6148"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b35050a5-e94f-46dc-bd05-2bbdac59e2da"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4cbada8d-67db-4e17-b9d9-d563f578294c"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dbd3c8c6-2af2-4471-991a-2cc02b12fe0c"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""R"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e346cd0e-f6d0-41f3-bf7b-fbece88de16b"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1f7962fa-35b9-4f51-9231-67e42785b841"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""E"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""69827636-43c9-45d1-aa3a-974a09f80228"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""33311ca5-2e80-403e-b48c-6515bbd88cca"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b39e46b-5748-4a4b-b247-3c191f31c419"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Q"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af013b8c-37aa-4ad1-abd3-f886aeed46be"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Space"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // BaseControl
        m_BaseControl = asset.FindActionMap("BaseControl", throwIfNotFound: true);
        m_BaseControl_Movement = m_BaseControl.FindAction("Movement", throwIfNotFound: true);
        m_BaseControl_Escape = m_BaseControl.FindAction("Escape", throwIfNotFound: true);
        m_BaseControl_R = m_BaseControl.FindAction("R", throwIfNotFound: true);
        m_BaseControl_Mouse = m_BaseControl.FindAction("Mouse", throwIfNotFound: true);
        m_BaseControl_E = m_BaseControl.FindAction("E", throwIfNotFound: true);
        m_BaseControl_LeftClick = m_BaseControl.FindAction("LeftClick", throwIfNotFound: true);
        m_BaseControl_RightClick = m_BaseControl.FindAction("RightClick", throwIfNotFound: true);
        m_BaseControl_Q = m_BaseControl.FindAction("Q", throwIfNotFound: true);
        m_BaseControl_Space = m_BaseControl.FindAction("Space", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // BaseControl
    private readonly InputActionMap m_BaseControl;
    private IBaseControlActions m_BaseControlActionsCallbackInterface;
    private readonly InputAction m_BaseControl_Movement;
    private readonly InputAction m_BaseControl_Escape;
    private readonly InputAction m_BaseControl_R;
    private readonly InputAction m_BaseControl_Mouse;
    private readonly InputAction m_BaseControl_E;
    private readonly InputAction m_BaseControl_LeftClick;
    private readonly InputAction m_BaseControl_RightClick;
    private readonly InputAction m_BaseControl_Q;
    private readonly InputAction m_BaseControl_Space;
    public struct BaseControlActions
    {
        private @Control m_Wrapper;
        public BaseControlActions(@Control wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_BaseControl_Movement;
        public InputAction @Escape => m_Wrapper.m_BaseControl_Escape;
        public InputAction @R => m_Wrapper.m_BaseControl_R;
        public InputAction @Mouse => m_Wrapper.m_BaseControl_Mouse;
        public InputAction @E => m_Wrapper.m_BaseControl_E;
        public InputAction @LeftClick => m_Wrapper.m_BaseControl_LeftClick;
        public InputAction @RightClick => m_Wrapper.m_BaseControl_RightClick;
        public InputAction @Q => m_Wrapper.m_BaseControl_Q;
        public InputAction @Space => m_Wrapper.m_BaseControl_Space;
        public InputActionMap Get() { return m_Wrapper.m_BaseControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BaseControlActions set) { return set.Get(); }
        public void SetCallbacks(IBaseControlActions instance)
        {
            if (m_Wrapper.m_BaseControlActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_BaseControlActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_BaseControlActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_BaseControlActionsCallbackInterface.OnMovement;
                @Escape.started -= m_Wrapper.m_BaseControlActionsCallbackInterface.OnEscape;
                @Escape.performed -= m_Wrapper.m_BaseControlActionsCallbackInterface.OnEscape;
                @Escape.canceled -= m_Wrapper.m_BaseControlActionsCallbackInterface.OnEscape;
                @R.started -= m_Wrapper.m_BaseControlActionsCallbackInterface.OnR;
                @R.performed -= m_Wrapper.m_BaseControlActionsCallbackInterface.OnR;
                @R.canceled -= m_Wrapper.m_BaseControlActionsCallbackInterface.OnR;
                @Mouse.started -= m_Wrapper.m_BaseControlActionsCallbackInterface.OnMouse;
                @Mouse.performed -= m_Wrapper.m_BaseControlActionsCallbackInterface.OnMouse;
                @Mouse.canceled -= m_Wrapper.m_BaseControlActionsCallbackInterface.OnMouse;
                @E.started -= m_Wrapper.m_BaseControlActionsCallbackInterface.OnE;
                @E.performed -= m_Wrapper.m_BaseControlActionsCallbackInterface.OnE;
                @E.canceled -= m_Wrapper.m_BaseControlActionsCallbackInterface.OnE;
                @LeftClick.started -= m_Wrapper.m_BaseControlActionsCallbackInterface.OnLeftClick;
                @LeftClick.performed -= m_Wrapper.m_BaseControlActionsCallbackInterface.OnLeftClick;
                @LeftClick.canceled -= m_Wrapper.m_BaseControlActionsCallbackInterface.OnLeftClick;
                @RightClick.started -= m_Wrapper.m_BaseControlActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_BaseControlActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_BaseControlActionsCallbackInterface.OnRightClick;
                @Q.started -= m_Wrapper.m_BaseControlActionsCallbackInterface.OnQ;
                @Q.performed -= m_Wrapper.m_BaseControlActionsCallbackInterface.OnQ;
                @Q.canceled -= m_Wrapper.m_BaseControlActionsCallbackInterface.OnQ;
                @Space.started -= m_Wrapper.m_BaseControlActionsCallbackInterface.OnSpace;
                @Space.performed -= m_Wrapper.m_BaseControlActionsCallbackInterface.OnSpace;
                @Space.canceled -= m_Wrapper.m_BaseControlActionsCallbackInterface.OnSpace;
            }
            m_Wrapper.m_BaseControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Escape.started += instance.OnEscape;
                @Escape.performed += instance.OnEscape;
                @Escape.canceled += instance.OnEscape;
                @R.started += instance.OnR;
                @R.performed += instance.OnR;
                @R.canceled += instance.OnR;
                @Mouse.started += instance.OnMouse;
                @Mouse.performed += instance.OnMouse;
                @Mouse.canceled += instance.OnMouse;
                @E.started += instance.OnE;
                @E.performed += instance.OnE;
                @E.canceled += instance.OnE;
                @LeftClick.started += instance.OnLeftClick;
                @LeftClick.performed += instance.OnLeftClick;
                @LeftClick.canceled += instance.OnLeftClick;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
                @Q.started += instance.OnQ;
                @Q.performed += instance.OnQ;
                @Q.canceled += instance.OnQ;
                @Space.started += instance.OnSpace;
                @Space.performed += instance.OnSpace;
                @Space.canceled += instance.OnSpace;
            }
        }
    }
    public BaseControlActions @BaseControl => new BaseControlActions(this);
    public interface IBaseControlActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnEscape(InputAction.CallbackContext context);
        void OnR(InputAction.CallbackContext context);
        void OnMouse(InputAction.CallbackContext context);
        void OnE(InputAction.CallbackContext context);
        void OnLeftClick(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
        void OnQ(InputAction.CallbackContext context);
        void OnSpace(InputAction.CallbackContext context);
    }
}
