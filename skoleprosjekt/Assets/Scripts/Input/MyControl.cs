// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input/MyControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MyControl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MyControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MyControl"",
    ""maps"": [
        {
            ""name"": ""GroundMovement"",
            ""id"": ""2b7cd11c-1efd-4833-9a2c-5d2db2b659d2"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""a6ee20e5-345b-442d-b843-cbc52d82ce37"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""5683ed71-151f-4da7-a412-11b6f9b3b92e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Grapple"",
                    ""type"": ""Button"",
                    ""id"": ""4d5748c2-4a1d-4e9a-b903-57e93067ec9a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pickup"",
                    ""type"": ""Button"",
                    ""id"": ""3ec13a5c-2635-4134-b408-67a31ed23866"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""f14b47f0-d073-4308-ac70-868c42253f54"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""96c46858-e89e-4212-9078-d53c001f5b9c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CloseUI"",
                    ""type"": ""Button"",
                    ""id"": ""3a6de82d-4fde-4483-ae59-af04669ea5d0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Console"",
                    ""type"": ""Button"",
                    ""id"": ""5130996f-87d2-43b5-b855-cfd57d2d05e1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Return"",
                    ""type"": ""Button"",
                    ""id"": ""fa6e7438-c9fd-4f9d-8540-ea51722f8d67"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""3rdPerson"",
                    ""type"": ""Button"",
                    ""id"": ""fdceb7f9-721d-42e0-bb4b-087302256a28"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Scroll"",
                    ""type"": ""Value"",
                    ""id"": ""2c3b7aff-e48c-49ab-a6b4-1f03f4139f09"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6cd3ccfb-42b2-455e-aaf9-6976923a2469"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""56421ab1-cf3f-48b8-875a-de7420da5cd7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7ae0be2d-1bdf-4ad7-8c75-96ee850de6eb"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ed78800f-1ad1-4b84-9a81-9c4decdeaeea"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""363dd9ac-7ced-4145-80bd-bc1bbd1fae83"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""52951a6b-4a0a-4c42-8274-0ba88a03f1cb"",
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
                    ""id"": ""e87b11f5-3ace-4cfb-b0c1-6b4f06a70875"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grapple"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""61e7938a-0e92-49c3-89eb-57d7ed7f981f"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pickup"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7a0c4239-2c51-47c9-8adb-0fd6e7a9bcf9"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1465478b-f6b8-4bd9-98e5-b7297bd6022f"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""090a82f0-eefa-4da6-9331-d46be70cbd76"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""80f5a138-6fff-4521-9e17-4c8710d33953"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CloseUI"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""74506cb4-eb4d-40b9-959e-48a747ced171"",
                    ""path"": ""<Keyboard>/quote"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Console"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94326b51-40a7-48f3-8be5-85f7eb049fc8"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Return"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""081e5714-49d9-4ae2-a39d-21e94e6bcd14"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""3rdPerson"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3a8614d9-f446-4c99-8b9a-256d75b1cb2c"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard & Mouse"",
            ""bindingGroup"": ""Keyboard & Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // GroundMovement
        m_GroundMovement = asset.FindActionMap("GroundMovement", throwIfNotFound: true);
        m_GroundMovement_Jump = m_GroundMovement.FindAction("Jump", throwIfNotFound: true);
        m_GroundMovement_Move = m_GroundMovement.FindAction("Move", throwIfNotFound: true);
        m_GroundMovement_Grapple = m_GroundMovement.FindAction("Grapple", throwIfNotFound: true);
        m_GroundMovement_Pickup = m_GroundMovement.FindAction("Pickup", throwIfNotFound: true);
        m_GroundMovement_Crouch = m_GroundMovement.FindAction("Crouch", throwIfNotFound: true);
        m_GroundMovement_Look = m_GroundMovement.FindAction("Look", throwIfNotFound: true);
        m_GroundMovement_CloseUI = m_GroundMovement.FindAction("CloseUI", throwIfNotFound: true);
        m_GroundMovement_Console = m_GroundMovement.FindAction("Console", throwIfNotFound: true);
        m_GroundMovement_Return = m_GroundMovement.FindAction("Return", throwIfNotFound: true);
        m_GroundMovement__3rdPerson = m_GroundMovement.FindAction("3rdPerson", throwIfNotFound: true);
        m_GroundMovement_Scroll = m_GroundMovement.FindAction("Scroll", throwIfNotFound: true);
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

    // GroundMovement
    private readonly InputActionMap m_GroundMovement;
    private IGroundMovementActions m_GroundMovementActionsCallbackInterface;
    private readonly InputAction m_GroundMovement_Jump;
    private readonly InputAction m_GroundMovement_Move;
    private readonly InputAction m_GroundMovement_Grapple;
    private readonly InputAction m_GroundMovement_Pickup;
    private readonly InputAction m_GroundMovement_Crouch;
    private readonly InputAction m_GroundMovement_Look;
    private readonly InputAction m_GroundMovement_CloseUI;
    private readonly InputAction m_GroundMovement_Console;
    private readonly InputAction m_GroundMovement_Return;
    private readonly InputAction m_GroundMovement__3rdPerson;
    private readonly InputAction m_GroundMovement_Scroll;
    public struct GroundMovementActions
    {
        private @MyControl m_Wrapper;
        public GroundMovementActions(@MyControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_GroundMovement_Jump;
        public InputAction @Move => m_Wrapper.m_GroundMovement_Move;
        public InputAction @Grapple => m_Wrapper.m_GroundMovement_Grapple;
        public InputAction @Pickup => m_Wrapper.m_GroundMovement_Pickup;
        public InputAction @Crouch => m_Wrapper.m_GroundMovement_Crouch;
        public InputAction @Look => m_Wrapper.m_GroundMovement_Look;
        public InputAction @CloseUI => m_Wrapper.m_GroundMovement_CloseUI;
        public InputAction @Console => m_Wrapper.m_GroundMovement_Console;
        public InputAction @Return => m_Wrapper.m_GroundMovement_Return;
        public InputAction @_3rdPerson => m_Wrapper.m_GroundMovement__3rdPerson;
        public InputAction @Scroll => m_Wrapper.m_GroundMovement_Scroll;
        public InputActionMap Get() { return m_Wrapper.m_GroundMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GroundMovementActions set) { return set.Get(); }
        public void SetCallbacks(IGroundMovementActions instance)
        {
            if (m_Wrapper.m_GroundMovementActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnJump;
                @Move.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnMove;
                @Grapple.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnGrapple;
                @Grapple.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnGrapple;
                @Grapple.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnGrapple;
                @Pickup.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnPickup;
                @Pickup.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnPickup;
                @Pickup.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnPickup;
                @Crouch.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnCrouch;
                @Look.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnLook;
                @CloseUI.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnCloseUI;
                @CloseUI.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnCloseUI;
                @CloseUI.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnCloseUI;
                @Console.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnConsole;
                @Console.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnConsole;
                @Console.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnConsole;
                @Return.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnReturn;
                @Return.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnReturn;
                @Return.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnReturn;
                @_3rdPerson.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.On_3rdPerson;
                @_3rdPerson.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.On_3rdPerson;
                @_3rdPerson.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.On_3rdPerson;
                @Scroll.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnScroll;
                @Scroll.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnScroll;
                @Scroll.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnScroll;
            }
            m_Wrapper.m_GroundMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Grapple.started += instance.OnGrapple;
                @Grapple.performed += instance.OnGrapple;
                @Grapple.canceled += instance.OnGrapple;
                @Pickup.started += instance.OnPickup;
                @Pickup.performed += instance.OnPickup;
                @Pickup.canceled += instance.OnPickup;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @CloseUI.started += instance.OnCloseUI;
                @CloseUI.performed += instance.OnCloseUI;
                @CloseUI.canceled += instance.OnCloseUI;
                @Console.started += instance.OnConsole;
                @Console.performed += instance.OnConsole;
                @Console.canceled += instance.OnConsole;
                @Return.started += instance.OnReturn;
                @Return.performed += instance.OnReturn;
                @Return.canceled += instance.OnReturn;
                @_3rdPerson.started += instance.On_3rdPerson;
                @_3rdPerson.performed += instance.On_3rdPerson;
                @_3rdPerson.canceled += instance.On_3rdPerson;
                @Scroll.started += instance.OnScroll;
                @Scroll.performed += instance.OnScroll;
                @Scroll.canceled += instance.OnScroll;
            }
        }
    }
    public GroundMovementActions @GroundMovement => new GroundMovementActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard & Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    public interface IGroundMovementActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnGrapple(InputAction.CallbackContext context);
        void OnPickup(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnCloseUI(InputAction.CallbackContext context);
        void OnConsole(InputAction.CallbackContext context);
        void OnReturn(InputAction.CallbackContext context);
        void On_3rdPerson(InputAction.CallbackContext context);
        void OnScroll(InputAction.CallbackContext context);
    }
}
