//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/InputActions/PlayerControls.inputactions
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

public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""InGameKeys"",
            ""id"": ""437fbb99-fa0a-4a26-8f02-30417f60621e"",
            ""actions"": [
                {
                    ""name"": ""ServeBall"",
                    ""type"": ""Button"",
                    ""id"": ""e04e4b1c-9315-4247-9125-93d0e1e5ca4d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Player1MoveUp"",
                    ""type"": ""Button"",
                    ""id"": ""9858898b-9b3a-47da-8f52-d825236dd1ea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Player1MoveDown"",
                    ""type"": ""Button"",
                    ""id"": ""3a63e302-7ef1-484c-a2fb-891716f92528"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Player2MoveUp"",
                    ""type"": ""Button"",
                    ""id"": ""c90194d2-9262-4eec-a991-9d435f1b80d1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Player2MoveDown"",
                    ""type"": ""Button"",
                    ""id"": ""367b7708-b92f-4061-973e-6583c5899f25"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""ee7fb565-0373-437e-8bc2-bfbdddb2cad8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b383d299-8ffd-4094-ab7d-db00fc482cb0"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ServeBall"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a8ced040-fc53-4087-9926-00d84bbd459c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player1MoveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""00951320-dc35-426f-afac-2642ba706b2f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player1MoveDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a8c6a4c4-1df2-4292-aa47-4c604331fea1"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player2MoveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9bf87790-ac4b-49a9-af2f-f57d4fc5e0d2"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player2MoveDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc71aace-0bd4-4929-b1d0-f384790c6dca"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5436f631-6aaf-4008-9b4f-93d50d1201bf"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // InGameKeys
        m_InGameKeys = asset.FindActionMap("InGameKeys", throwIfNotFound: true);
        m_InGameKeys_ServeBall = m_InGameKeys.FindAction("ServeBall", throwIfNotFound: true);
        m_InGameKeys_Player1MoveUp = m_InGameKeys.FindAction("Player1MoveUp", throwIfNotFound: true);
        m_InGameKeys_Player1MoveDown = m_InGameKeys.FindAction("Player1MoveDown", throwIfNotFound: true);
        m_InGameKeys_Player2MoveUp = m_InGameKeys.FindAction("Player2MoveUp", throwIfNotFound: true);
        m_InGameKeys_Player2MoveDown = m_InGameKeys.FindAction("Player2MoveDown", throwIfNotFound: true);
        m_InGameKeys_Pause = m_InGameKeys.FindAction("Pause", throwIfNotFound: true);
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

    // InGameKeys
    private readonly InputActionMap m_InGameKeys;
    private List<IInGameKeysActions> m_InGameKeysActionsCallbackInterfaces = new List<IInGameKeysActions>();
    private readonly InputAction m_InGameKeys_ServeBall;
    private readonly InputAction m_InGameKeys_Player1MoveUp;
    private readonly InputAction m_InGameKeys_Player1MoveDown;
    private readonly InputAction m_InGameKeys_Player2MoveUp;
    private readonly InputAction m_InGameKeys_Player2MoveDown;
    private readonly InputAction m_InGameKeys_Pause;
    public struct InGameKeysActions
    {
        private @PlayerControls m_Wrapper;
        public InGameKeysActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @ServeBall => m_Wrapper.m_InGameKeys_ServeBall;
        public InputAction @Player1MoveUp => m_Wrapper.m_InGameKeys_Player1MoveUp;
        public InputAction @Player1MoveDown => m_Wrapper.m_InGameKeys_Player1MoveDown;
        public InputAction @Player2MoveUp => m_Wrapper.m_InGameKeys_Player2MoveUp;
        public InputAction @Player2MoveDown => m_Wrapper.m_InGameKeys_Player2MoveDown;
        public InputAction @Pause => m_Wrapper.m_InGameKeys_Pause;
        public InputActionMap Get() { return m_Wrapper.m_InGameKeys; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InGameKeysActions set) { return set.Get(); }
        public void AddCallbacks(IInGameKeysActions instance)
        {
            if (instance == null || m_Wrapper.m_InGameKeysActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_InGameKeysActionsCallbackInterfaces.Add(instance);
            @ServeBall.started += instance.OnServeBall;
            @ServeBall.performed += instance.OnServeBall;
            @ServeBall.canceled += instance.OnServeBall;
            @Player1MoveUp.started += instance.OnPlayer1MoveUp;
            @Player1MoveUp.performed += instance.OnPlayer1MoveUp;
            @Player1MoveUp.canceled += instance.OnPlayer1MoveUp;
            @Player1MoveDown.started += instance.OnPlayer1MoveDown;
            @Player1MoveDown.performed += instance.OnPlayer1MoveDown;
            @Player1MoveDown.canceled += instance.OnPlayer1MoveDown;
            @Player2MoveUp.started += instance.OnPlayer2MoveUp;
            @Player2MoveUp.performed += instance.OnPlayer2MoveUp;
            @Player2MoveUp.canceled += instance.OnPlayer2MoveUp;
            @Player2MoveDown.started += instance.OnPlayer2MoveDown;
            @Player2MoveDown.performed += instance.OnPlayer2MoveDown;
            @Player2MoveDown.canceled += instance.OnPlayer2MoveDown;
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
        }

        private void UnregisterCallbacks(IInGameKeysActions instance)
        {
            @ServeBall.started -= instance.OnServeBall;
            @ServeBall.performed -= instance.OnServeBall;
            @ServeBall.canceled -= instance.OnServeBall;
            @Player1MoveUp.started -= instance.OnPlayer1MoveUp;
            @Player1MoveUp.performed -= instance.OnPlayer1MoveUp;
            @Player1MoveUp.canceled -= instance.OnPlayer1MoveUp;
            @Player1MoveDown.started -= instance.OnPlayer1MoveDown;
            @Player1MoveDown.performed -= instance.OnPlayer1MoveDown;
            @Player1MoveDown.canceled -= instance.OnPlayer1MoveDown;
            @Player2MoveUp.started -= instance.OnPlayer2MoveUp;
            @Player2MoveUp.performed -= instance.OnPlayer2MoveUp;
            @Player2MoveUp.canceled -= instance.OnPlayer2MoveUp;
            @Player2MoveDown.started -= instance.OnPlayer2MoveDown;
            @Player2MoveDown.performed -= instance.OnPlayer2MoveDown;
            @Player2MoveDown.canceled -= instance.OnPlayer2MoveDown;
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
        }

        public void RemoveCallbacks(IInGameKeysActions instance)
        {
            if (m_Wrapper.m_InGameKeysActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IInGameKeysActions instance)
        {
            foreach (var item in m_Wrapper.m_InGameKeysActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_InGameKeysActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public InGameKeysActions @InGameKeys => new InGameKeysActions(this);
    public interface IInGameKeysActions
    {
        void OnServeBall(InputAction.CallbackContext context);
        void OnPlayer1MoveUp(InputAction.CallbackContext context);
        void OnPlayer1MoveDown(InputAction.CallbackContext context);
        void OnPlayer2MoveUp(InputAction.CallbackContext context);
        void OnPlayer2MoveDown(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}
