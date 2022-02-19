// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerInputAction.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputAction : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputAction"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""3503a7c3-7cca-4ef2-a34a-2d8752924220"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""b81b68e8-d65a-42b5-80c2-8f6504172465"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeColor"",
                    ""type"": ""Button"",
                    ""id"": ""5f1cf232-0035-4238-9d29-4d0040d0ae41"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""883afbd4-e536-4dd4-91a6-3aa559b15dc5"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DrivingState"",
                    ""type"": ""Button"",
                    ""id"": ""54071c6a-7c0c-46c9-b341-159c98b94659"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""a0f0ea4a-8835-448d-8445-509a2fab976d"",
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
                    ""id"": ""f8e212c4-d692-4adc-9324-baccf88ef904"",
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
                    ""id"": ""7fb3e9ae-b0ab-40b4-9a42-ebea428ed2f0"",
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
                    ""id"": ""2f575059-5533-4273-aba8-36788e7d1b73"",
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
                    ""id"": ""23188cce-0ce8-4cda-8118-342c30de6742"",
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
                    ""id"": ""d515f7bb-9ce4-4c06-a23c-af7da799dc38"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeColor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""9f21263b-4a0d-499c-bf14-2ebade2bea8c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9700c351-4fcb-45aa-92f5-90c873f3ba99"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5a05ee39-497c-4f58-a802-5ddf727d6704"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""967648f9-169b-4383-a71a-5d77b5331890"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DrivingState"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Driving"",
            ""id"": ""b163af7e-87fb-48f0-9a0e-03689964add1"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""551fa1fb-a99f-4164-810c-a0b9d252fb61"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PlayerState"",
                    ""type"": ""Button"",
                    ""id"": ""80c17633-ba42-43ac-a11f-7114d6eab5fe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""92933ae3-f6f1-4819-a812-963b14ded338"",
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
                    ""id"": ""927220c6-0b32-41ab-96ce-6fb0a121f67a"",
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
                    ""id"": ""3eb4eec7-f678-4e42-8943-d9ebb70a813d"",
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
                    ""id"": ""c46e708d-712d-4eb3-a71c-acdb579f4bc8"",
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
                    ""id"": ""1ab7f45e-4fab-4fa7-a942-fc8534a21c62"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""0c285552-36de-447e-827c-dcaf99b0e344"",
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
                    ""id"": ""32e9609f-f903-4fd5-a24a-c6e9060f816c"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1f1795dd-013f-48e9-b74e-7f3a1e8d48b4"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d10dd538-697e-449c-bbc6-35dd19cbc73e"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5c6222dd-73de-40ba-9e31-c5416a94f273"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d025024c-c62b-4db9-8955-5dff34056fc3"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerState"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""SpherePlayer"",
            ""id"": ""8efc70ac-2ac3-4a83-88c9-ad1b99cbc26a"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c1b66dbd-b4d0-4ff8-b854-3590d9e3118f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap,Hold(pressPoint=1)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f09f9efc-decf-457f-a242-603ee7188cfc"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_ChangeColor = m_Player.FindAction("ChangeColor", throwIfNotFound: true);
        m_Player_Rotate = m_Player.FindAction("Rotate", throwIfNotFound: true);
        m_Player_DrivingState = m_Player.FindAction("DrivingState", throwIfNotFound: true);
        // Driving
        m_Driving = asset.FindActionMap("Driving", throwIfNotFound: true);
        m_Driving_Movement = m_Driving.FindAction("Movement", throwIfNotFound: true);
        m_Driving_PlayerState = m_Driving.FindAction("PlayerState", throwIfNotFound: true);
        // SpherePlayer
        m_SpherePlayer = asset.FindActionMap("SpherePlayer", throwIfNotFound: true);
        m_SpherePlayer_Jump = m_SpherePlayer.FindAction("Jump", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_ChangeColor;
    private readonly InputAction m_Player_Rotate;
    private readonly InputAction m_Player_DrivingState;
    public struct PlayerActions
    {
        private @PlayerInputAction m_Wrapper;
        public PlayerActions(@PlayerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @ChangeColor => m_Wrapper.m_Player_ChangeColor;
        public InputAction @Rotate => m_Wrapper.m_Player_Rotate;
        public InputAction @DrivingState => m_Wrapper.m_Player_DrivingState;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @ChangeColor.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeColor;
                @ChangeColor.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeColor;
                @ChangeColor.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeColor;
                @Rotate.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                @DrivingState.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDrivingState;
                @DrivingState.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDrivingState;
                @DrivingState.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDrivingState;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @ChangeColor.started += instance.OnChangeColor;
                @ChangeColor.performed += instance.OnChangeColor;
                @ChangeColor.canceled += instance.OnChangeColor;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @DrivingState.started += instance.OnDrivingState;
                @DrivingState.performed += instance.OnDrivingState;
                @DrivingState.canceled += instance.OnDrivingState;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Driving
    private readonly InputActionMap m_Driving;
    private IDrivingActions m_DrivingActionsCallbackInterface;
    private readonly InputAction m_Driving_Movement;
    private readonly InputAction m_Driving_PlayerState;
    public struct DrivingActions
    {
        private @PlayerInputAction m_Wrapper;
        public DrivingActions(@PlayerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Driving_Movement;
        public InputAction @PlayerState => m_Wrapper.m_Driving_PlayerState;
        public InputActionMap Get() { return m_Wrapper.m_Driving; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DrivingActions set) { return set.Get(); }
        public void SetCallbacks(IDrivingActions instance)
        {
            if (m_Wrapper.m_DrivingActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnMovement;
                @PlayerState.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnPlayerState;
                @PlayerState.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnPlayerState;
                @PlayerState.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnPlayerState;
            }
            m_Wrapper.m_DrivingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @PlayerState.started += instance.OnPlayerState;
                @PlayerState.performed += instance.OnPlayerState;
                @PlayerState.canceled += instance.OnPlayerState;
            }
        }
    }
    public DrivingActions @Driving => new DrivingActions(this);

    // SpherePlayer
    private readonly InputActionMap m_SpherePlayer;
    private ISpherePlayerActions m_SpherePlayerActionsCallbackInterface;
    private readonly InputAction m_SpherePlayer_Jump;
    public struct SpherePlayerActions
    {
        private @PlayerInputAction m_Wrapper;
        public SpherePlayerActions(@PlayerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_SpherePlayer_Jump;
        public InputActionMap Get() { return m_Wrapper.m_SpherePlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SpherePlayerActions set) { return set.Get(); }
        public void SetCallbacks(ISpherePlayerActions instance)
        {
            if (m_Wrapper.m_SpherePlayerActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_SpherePlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_SpherePlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_SpherePlayerActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_SpherePlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public SpherePlayerActions @SpherePlayer => new SpherePlayerActions(this);
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnChangeColor(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnDrivingState(InputAction.CallbackContext context);
    }
    public interface IDrivingActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnPlayerState(InputAction.CallbackContext context);
    }
    public interface ISpherePlayerActions
    {
        void OnJump(InputAction.CallbackContext context);
    }
}
