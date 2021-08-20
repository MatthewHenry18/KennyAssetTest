// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerActionControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActionControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""LandMovement"",
            ""id"": ""b236e99c-c489-41fe-9907-a46304cbd425"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6c5bfdc6-f795-4c6c-8f6f-0be6588ad9f7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""74665e54-eaa5-4ee9-85bf-30bc6579f551"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Climb"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c7a5b025-b9a3-4680-9b11-03b1162e2c82"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""HorizontalMovement"",
                    ""id"": ""8af93c1c-9413-40f7-a2b3-c1a5af82dd42"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""3299ed1b-2798-49b9-84b3-570e7a68599c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f6720e7a-d2bf-4484-bc8d-74fb04063c3a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1aa6781c-d0ca-431b-830a-1e8704108e4a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""VerticalMovement"",
                    ""id"": ""88b2d3fa-14e7-441e-8c4d-565ae2177839"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Climb"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""dc033e5a-5a93-4877-807a-e5d0bf12856f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Climb"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""99bcb4c7-7219-48df-bba6-6e1190285ba8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Climb"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // LandMovement
        m_LandMovement = asset.FindActionMap("LandMovement", throwIfNotFound: true);
        m_LandMovement_Move = m_LandMovement.FindAction("Move", throwIfNotFound: true);
        m_LandMovement_Jump = m_LandMovement.FindAction("Jump", throwIfNotFound: true);
        m_LandMovement_Climb = m_LandMovement.FindAction("Climb", throwIfNotFound: true);
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

    // LandMovement
    private readonly InputActionMap m_LandMovement;
    private ILandMovementActions m_LandMovementActionsCallbackInterface;
    private readonly InputAction m_LandMovement_Move;
    private readonly InputAction m_LandMovement_Jump;
    private readonly InputAction m_LandMovement_Climb;
    public struct LandMovementActions
    {
        private @PlayerActionControls m_Wrapper;
        public LandMovementActions(@PlayerActionControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_LandMovement_Move;
        public InputAction @Jump => m_Wrapper.m_LandMovement_Jump;
        public InputAction @Climb => m_Wrapper.m_LandMovement_Climb;
        public InputActionMap Get() { return m_Wrapper.m_LandMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LandMovementActions set) { return set.Get(); }
        public void SetCallbacks(ILandMovementActions instance)
        {
            if (m_Wrapper.m_LandMovementActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_LandMovementActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_LandMovementActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_LandMovementActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_LandMovementActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_LandMovementActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_LandMovementActionsCallbackInterface.OnJump;
                @Climb.started -= m_Wrapper.m_LandMovementActionsCallbackInterface.OnClimb;
                @Climb.performed -= m_Wrapper.m_LandMovementActionsCallbackInterface.OnClimb;
                @Climb.canceled -= m_Wrapper.m_LandMovementActionsCallbackInterface.OnClimb;
            }
            m_Wrapper.m_LandMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Climb.started += instance.OnClimb;
                @Climb.performed += instance.OnClimb;
                @Climb.canceled += instance.OnClimb;
            }
        }
    }
    public LandMovementActions @LandMovement => new LandMovementActions(this);
    public interface ILandMovementActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnClimb(InputAction.CallbackContext context);
    }
}
