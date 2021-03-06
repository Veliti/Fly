//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/Input/Controls.inputactions
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

public partial class @Controls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Ship"",
            ""id"": ""5a4ae96e-e389-4775-9005-32efe1190aab"",
            ""actions"": [
                {
                    ""name"": ""MoveCharacter"",
                    ""type"": ""Value"",
                    ""id"": ""877b691f-718c-478d-9ce0-f882ba3e50ad"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MoveCamera"",
                    ""type"": ""Value"",
                    ""id"": ""464060c3-80ed-4ecb-880d-e810d7a5555b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""BarrelRotate"",
                    ""type"": ""Value"",
                    ""id"": ""417150a3-2c31-4b10-ad1e-b33ea3379a96"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""9642137a-c052-4e35-ae0b-91a71c71c390"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCharacter"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""af7d9044-30f9-430a-8b6e-ef5331df008c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCharacter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5a630d8d-e223-4e85-a427-2d815afb06f9"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCharacter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0f5ac982-6f0b-4da0-97e1-9b06fadc5190"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCharacter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""491b6c8e-1c25-44f1-b8e1-34d95e58286a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCharacter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a49567d6-d3f9-4aa4-9ac9-e6e7f010e4f7"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""5af15f75-a58e-4ac3-ac56-3e7295c985d3"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BarrelRotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""218fa864-0c57-4f7e-b6cc-b1b67fe8c01e"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BarrelRotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""478a7a46-375f-44a7-b28b-9ebfc7dbd6b6"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BarrelRotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Ship
        m_Ship = asset.FindActionMap("Ship", throwIfNotFound: true);
        m_Ship_MoveCharacter = m_Ship.FindAction("MoveCharacter", throwIfNotFound: true);
        m_Ship_MoveCamera = m_Ship.FindAction("MoveCamera", throwIfNotFound: true);
        m_Ship_BarrelRotate = m_Ship.FindAction("BarrelRotate", throwIfNotFound: true);
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

    // Ship
    private readonly InputActionMap m_Ship;
    private IShipActions m_ShipActionsCallbackInterface;
    private readonly InputAction m_Ship_MoveCharacter;
    private readonly InputAction m_Ship_MoveCamera;
    private readonly InputAction m_Ship_BarrelRotate;
    public struct ShipActions
    {
        private @Controls m_Wrapper;
        public ShipActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveCharacter => m_Wrapper.m_Ship_MoveCharacter;
        public InputAction @MoveCamera => m_Wrapper.m_Ship_MoveCamera;
        public InputAction @BarrelRotate => m_Wrapper.m_Ship_BarrelRotate;
        public InputActionMap Get() { return m_Wrapper.m_Ship; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ShipActions set) { return set.Get(); }
        public void SetCallbacks(IShipActions instance)
        {
            if (m_Wrapper.m_ShipActionsCallbackInterface != null)
            {
                @MoveCharacter.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnMoveCharacter;
                @MoveCharacter.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnMoveCharacter;
                @MoveCharacter.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnMoveCharacter;
                @MoveCamera.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnMoveCamera;
                @MoveCamera.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnMoveCamera;
                @MoveCamera.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnMoveCamera;
                @BarrelRotate.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnBarrelRotate;
                @BarrelRotate.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnBarrelRotate;
                @BarrelRotate.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnBarrelRotate;
            }
            m_Wrapper.m_ShipActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveCharacter.started += instance.OnMoveCharacter;
                @MoveCharacter.performed += instance.OnMoveCharacter;
                @MoveCharacter.canceled += instance.OnMoveCharacter;
                @MoveCamera.started += instance.OnMoveCamera;
                @MoveCamera.performed += instance.OnMoveCamera;
                @MoveCamera.canceled += instance.OnMoveCamera;
                @BarrelRotate.started += instance.OnBarrelRotate;
                @BarrelRotate.performed += instance.OnBarrelRotate;
                @BarrelRotate.canceled += instance.OnBarrelRotate;
            }
        }
    }
    public ShipActions @Ship => new ShipActions(this);
    public interface IShipActions
    {
        void OnMoveCharacter(InputAction.CallbackContext context);
        void OnMoveCamera(InputAction.CallbackContext context);
        void OnBarrelRotate(InputAction.CallbackContext context);
    }
}
