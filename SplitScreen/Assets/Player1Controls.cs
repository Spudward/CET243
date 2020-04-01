// GENERATED AUTOMATICALLY FROM 'Assets/Player1Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Player1Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player1Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player1Controls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""26977a0f-3d3f-400f-a392-b6da99114d8f"",
            ""actions"": [
                {
                    ""name"": ""Grow"",
                    ""type"": ""Button"",
                    ""id"": ""5ecc1862-2c69-4e29-be0f-b77328b16c8d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""83e9e48c-7fa5-4179-a265-5c73eadad464"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Button"",
                    ""id"": ""ded6db4a-5542-4b36-89e3-fecddd1bb2ba"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""5ffb5c39-ecc4-4af7-a5b8-c781e7c76b84"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a6eed727-26d8-4be7-aa12-e44dd024d720"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8728ea67-c4c5-4cc9-be8d-0d0c2abf5227"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f7800c52-0a44-47ec-9a90-25e09a846b95"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4345445c-7edc-4e1d-9361-6b73c8b40511"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Grow = m_Gameplay.FindAction("Grow", throwIfNotFound: true);
        m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
        m_Gameplay_Rotate = m_Gameplay.FindAction("Rotate", throwIfNotFound: true);
        m_Gameplay_Shoot = m_Gameplay.FindAction("Shoot", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Grow;
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_Rotate;
    private readonly InputAction m_Gameplay_Shoot;
    public struct GameplayActions
    {
        private @Player1Controls m_Wrapper;
        public GameplayActions(@Player1Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Grow => m_Wrapper.m_Gameplay_Grow;
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputAction @Rotate => m_Wrapper.m_Gameplay_Rotate;
        public InputAction @Shoot => m_Wrapper.m_Gameplay_Shoot;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Grow.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGrow;
                @Grow.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGrow;
                @Grow.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGrow;
                @Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Rotate.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotate;
                @Shoot.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShoot;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Grow.started += instance.OnGrow;
                @Grow.performed += instance.OnGrow;
                @Grow.canceled += instance.OnGrow;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnGrow(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
    }
}
