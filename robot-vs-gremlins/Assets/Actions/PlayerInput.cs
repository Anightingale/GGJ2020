// GENERATED AUTOMATICALLY FROM 'Assets/Actions/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Gremlin"",
            ""id"": ""5fc816b4-a853-4456-b9bb-a138b97194f1"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""db25f3fb-bb8d-49a3-a7ba-4c47758e61cf"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GrabStart"",
                    ""type"": ""Button"",
                    ""id"": ""8e18993f-fb8b-482d-96f7-dc02ffed8791"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""GrabStop"",
                    ""type"": ""Button"",
                    ""id"": ""1c2a9526-95b4-42d8-b499-15734d54cd3f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""Special"",
                    ""type"": ""Button"",
                    ""id"": ""31023ffe-2e7e-4bee-9f4c-2fdf5cad119c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""978bfe49-cc26-4a3d-ab7b-7d7a29327403"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""00ca640b-d935-4593-8157-c05846ea39b3"",
                    ""path"": ""Dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4504f5bf-9318-4444-8cb1-71c2eea8c326"",
                    ""path"": ""<HID::Logicool Logicool Dual Action>/hat/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Logicool Shitty Controller"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0c28bdcf-8f04-4ce8-99aa-56ef33b4c79a"",
                    ""path"": ""<HID::Logicool Logicool Dual Action>/hat/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Logicool Shitty Controller"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ab423572-a451-4714-93fe-599799389b46"",
                    ""path"": ""<HID::Logicool Logicool Dual Action>/hat/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Logicool Shitty Controller"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""315f5e1f-5d17-40c3-afec-c6f902dc3aac"",
                    ""path"": ""<HID::Logicool Logicool Dual Action>/hat/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Logicool Shitty Controller"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""629ad02a-2d5f-4650-be72-de2004a88611"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d147cbdd-ef23-452d-b854-f3e498b86cd4"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""GrabStart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b2266e77-ddde-41ab-94d3-7d36dafc9180"",
                    ""path"": ""<HID::Logicool Logicool Dual Action>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Logicool Shitty Controller"",
                    ""action"": ""GrabStart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4d6fb1e9-be6f-4930-afd2-bf5f4c2eafb1"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GrabStart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""70fec4f7-e013-44ba-8f0d-0ab7dbb14a30"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Special"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8cfc3827-bad4-4966-86bc-8195b39baa95"",
                    ""path"": ""<HID::Logicool Logicool Dual Action>/button2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Logicool Shitty Controller"",
                    ""action"": ""Special"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5f4b001b-ac81-45c5-8ffb-0fe1fd26b15a"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""GrabStop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""407d2af6-c018-4d9c-870d-7601e8534011"",
                    ""path"": ""<HID::Logicool Logicool Dual Action>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Logicool Shitty Controller"",
                    ""action"": ""GrabStop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Robot"",
            ""id"": ""ae7fbd2f-9175-4900-a77f-2d44b5668593"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""5c7898c3-baa7-4710-9d65-017a09448eb0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Value"",
                    ""id"": ""b9ffe607-5976-47fd-a1e5-a90f9c6b1de7"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""d95977ef-dd8a-4f73-95f1-175062794ca1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""StopShoot"",
                    ""type"": ""Button"",
                    ""id"": ""18aa2058-babe-4cc1-828d-4255424af334"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""9a047ea9-c269-42c4-96c9-1a6b5a13e882"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b44b84f8-f6ff-42a2-99de-2905a19d0b7d"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""55e31b0f-ea6b-486b-9c78-31830b0f5653"",
                    ""path"": ""<HID::Logicool Logicool Dual Action>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Logicool Shitty Controller"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bfb8bb67-2f14-4127-afdb-292346fa62fa"",
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a390f844-efdd-4598-8de8-bb6595d64100"",
                    ""path"": ""<HID::Logicool Logicool Dual Action>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Logicool Shitty Controller"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1355c6b0-235e-44fe-847a-a977225b9854"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5566ca46-b312-4d83-8a86-52588bbb4030"",
                    ""path"": ""<HID::Logicool Logicool Dual Action>/button8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Logicool Shitty Controller"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da2a84d0-eda2-4f88-8419-5d6a30776516"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c762e7a9-3e64-4b24-a2b5-44d0890211cb"",
                    ""path"": ""<HID::Logicool Logicool Dual Action>/button2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Logicool Shitty Controller"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e717b043-425a-4131-8145-9d7f49a27c94"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""StopShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d8b1e356-354a-4285-9cc9-25a1eaaea956"",
                    ""path"": ""<HID::Logicool Logicool Dual Action>/button8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Logicool Shitty Controller"",
                    ""action"": ""StopShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Logicool Shitty Controller"",
            ""bindingGroup"": ""Logicool Shitty Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<HID::Logicool Logicool Dual Action>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Gremlin
        m_Gremlin = asset.FindActionMap("Gremlin", throwIfNotFound: true);
        m_Gremlin_Move = m_Gremlin.FindAction("Move", throwIfNotFound: true);
        m_Gremlin_GrabStart = m_Gremlin.FindAction("GrabStart", throwIfNotFound: true);
        m_Gremlin_GrabStop = m_Gremlin.FindAction("GrabStop", throwIfNotFound: true);
        m_Gremlin_Special = m_Gremlin.FindAction("Special", throwIfNotFound: true);
        // Robot
        m_Robot = asset.FindActionMap("Robot", throwIfNotFound: true);
        m_Robot_Move = m_Robot.FindAction("Move", throwIfNotFound: true);
        m_Robot_Aim = m_Robot.FindAction("Aim", throwIfNotFound: true);
        m_Robot_Shoot = m_Robot.FindAction("Shoot", throwIfNotFound: true);
        m_Robot_StopShoot = m_Robot.FindAction("StopShoot", throwIfNotFound: true);
        m_Robot_Jump = m_Robot.FindAction("Jump", throwIfNotFound: true);
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

    // Gremlin
    private readonly InputActionMap m_Gremlin;
    private IGremlinActions m_GremlinActionsCallbackInterface;
    private readonly InputAction m_Gremlin_Move;
    private readonly InputAction m_Gremlin_GrabStart;
    private readonly InputAction m_Gremlin_GrabStop;
    private readonly InputAction m_Gremlin_Special;
    public struct GremlinActions
    {
        private @PlayerInput m_Wrapper;
        public GremlinActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Gremlin_Move;
        public InputAction @GrabStart => m_Wrapper.m_Gremlin_GrabStart;
        public InputAction @GrabStop => m_Wrapper.m_Gremlin_GrabStop;
        public InputAction @Special => m_Wrapper.m_Gremlin_Special;
        public InputActionMap Get() { return m_Wrapper.m_Gremlin; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GremlinActions set) { return set.Get(); }
        public void SetCallbacks(IGremlinActions instance)
        {
            if (m_Wrapper.m_GremlinActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_GremlinActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GremlinActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GremlinActionsCallbackInterface.OnMove;
                @GrabStart.started -= m_Wrapper.m_GremlinActionsCallbackInterface.OnGrabStart;
                @GrabStart.performed -= m_Wrapper.m_GremlinActionsCallbackInterface.OnGrabStart;
                @GrabStart.canceled -= m_Wrapper.m_GremlinActionsCallbackInterface.OnGrabStart;
                @GrabStop.started -= m_Wrapper.m_GremlinActionsCallbackInterface.OnGrabStop;
                @GrabStop.performed -= m_Wrapper.m_GremlinActionsCallbackInterface.OnGrabStop;
                @GrabStop.canceled -= m_Wrapper.m_GremlinActionsCallbackInterface.OnGrabStop;
                @Special.started -= m_Wrapper.m_GremlinActionsCallbackInterface.OnSpecial;
                @Special.performed -= m_Wrapper.m_GremlinActionsCallbackInterface.OnSpecial;
                @Special.canceled -= m_Wrapper.m_GremlinActionsCallbackInterface.OnSpecial;
            }
            m_Wrapper.m_GremlinActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @GrabStart.started += instance.OnGrabStart;
                @GrabStart.performed += instance.OnGrabStart;
                @GrabStart.canceled += instance.OnGrabStart;
                @GrabStop.started += instance.OnGrabStop;
                @GrabStop.performed += instance.OnGrabStop;
                @GrabStop.canceled += instance.OnGrabStop;
                @Special.started += instance.OnSpecial;
                @Special.performed += instance.OnSpecial;
                @Special.canceled += instance.OnSpecial;
            }
        }
    }
    public GremlinActions @Gremlin => new GremlinActions(this);

    // Robot
    private readonly InputActionMap m_Robot;
    private IRobotActions m_RobotActionsCallbackInterface;
    private readonly InputAction m_Robot_Move;
    private readonly InputAction m_Robot_Aim;
    private readonly InputAction m_Robot_Shoot;
    private readonly InputAction m_Robot_StopShoot;
    private readonly InputAction m_Robot_Jump;
    public struct RobotActions
    {
        private @PlayerInput m_Wrapper;
        public RobotActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Robot_Move;
        public InputAction @Aim => m_Wrapper.m_Robot_Aim;
        public InputAction @Shoot => m_Wrapper.m_Robot_Shoot;
        public InputAction @StopShoot => m_Wrapper.m_Robot_StopShoot;
        public InputAction @Jump => m_Wrapper.m_Robot_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Robot; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RobotActions set) { return set.Get(); }
        public void SetCallbacks(IRobotActions instance)
        {
            if (m_Wrapper.m_RobotActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_RobotActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_RobotActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_RobotActionsCallbackInterface.OnMove;
                @Aim.started -= m_Wrapper.m_RobotActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_RobotActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_RobotActionsCallbackInterface.OnAim;
                @Shoot.started -= m_Wrapper.m_RobotActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_RobotActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_RobotActionsCallbackInterface.OnShoot;
                @StopShoot.started -= m_Wrapper.m_RobotActionsCallbackInterface.OnStopShoot;
                @StopShoot.performed -= m_Wrapper.m_RobotActionsCallbackInterface.OnStopShoot;
                @StopShoot.canceled -= m_Wrapper.m_RobotActionsCallbackInterface.OnStopShoot;
                @Jump.started -= m_Wrapper.m_RobotActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_RobotActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_RobotActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_RobotActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @StopShoot.started += instance.OnStopShoot;
                @StopShoot.performed += instance.OnStopShoot;
                @StopShoot.canceled += instance.OnStopShoot;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public RobotActions @Robot => new RobotActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_LogicoolShittyControllerSchemeIndex = -1;
    public InputControlScheme LogicoolShittyControllerScheme
    {
        get
        {
            if (m_LogicoolShittyControllerSchemeIndex == -1) m_LogicoolShittyControllerSchemeIndex = asset.FindControlSchemeIndex("Logicool Shitty Controller");
            return asset.controlSchemes[m_LogicoolShittyControllerSchemeIndex];
        }
    }
    public interface IGremlinActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnGrabStart(InputAction.CallbackContext context);
        void OnGrabStop(InputAction.CallbackContext context);
        void OnSpecial(InputAction.CallbackContext context);
    }
    public interface IRobotActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnStopShoot(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
