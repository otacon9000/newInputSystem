// GENERATED AUTOMATICALLY FROM 'Assets/Input/InputActionPlayer.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActionPlayer : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActionPlayer()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActionPlayer"",
    ""maps"": [
        {
            ""name"": ""UIMap"",
            ""id"": ""b3da4985-d56e-4d2b-967c-a3f36f2ccddc"",
            ""actions"": [
                {
                    ""name"": ""FillBar"",
                    ""type"": ""Button"",
                    ""id"": ""6a2eef6e-9e99-4772-b7d9-0358559cb9f1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c6e5f271-03d5-4a9b-a7e5-01808483e70a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FillBar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // UIMap
        m_UIMap = asset.FindActionMap("UIMap", throwIfNotFound: true);
        m_UIMap_FillBar = m_UIMap.FindAction("FillBar", throwIfNotFound: true);
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

    // UIMap
    private readonly InputActionMap m_UIMap;
    private IUIMapActions m_UIMapActionsCallbackInterface;
    private readonly InputAction m_UIMap_FillBar;
    public struct UIMapActions
    {
        private @InputActionPlayer m_Wrapper;
        public UIMapActions(@InputActionPlayer wrapper) { m_Wrapper = wrapper; }
        public InputAction @FillBar => m_Wrapper.m_UIMap_FillBar;
        public InputActionMap Get() { return m_Wrapper.m_UIMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIMapActions set) { return set.Get(); }
        public void SetCallbacks(IUIMapActions instance)
        {
            if (m_Wrapper.m_UIMapActionsCallbackInterface != null)
            {
                @FillBar.started -= m_Wrapper.m_UIMapActionsCallbackInterface.OnFillBar;
                @FillBar.performed -= m_Wrapper.m_UIMapActionsCallbackInterface.OnFillBar;
                @FillBar.canceled -= m_Wrapper.m_UIMapActionsCallbackInterface.OnFillBar;
            }
            m_Wrapper.m_UIMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @FillBar.started += instance.OnFillBar;
                @FillBar.performed += instance.OnFillBar;
                @FillBar.canceled += instance.OnFillBar;
            }
        }
    }
    public UIMapActions @UIMap => new UIMapActions(this);
    public interface IUIMapActions
    {
        void OnFillBar(InputAction.CallbackContext context);
    }
}
