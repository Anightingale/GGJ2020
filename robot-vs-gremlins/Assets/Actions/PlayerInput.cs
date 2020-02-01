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
                    ""id"": ""e2062cb9-1b15-46a2-838c-2f8d72a0bdd9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8180e8bd-4097-4f4e-ab88-4523101a6ce9"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""320bffee-a40b-4347-ac70-c210eb8bc73a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1c5327b5-f71c-4f60-99c7-4e737386f1d1"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d2581a9b-1d11-4566-b27d-b92aff5fabbc"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2e46982e-44cc-431b-9f0b-c11910bf467a"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fcfe95b8-67b9-4526-84b5-5d0bc98d6400"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""77bff152-3580-4b21-b6de-dcd0c7e41164"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4504f5bf-9318-4444-8cb1-71c2eea8c326"",
                    ""path"": ""<HID::Logicool Logicool Dual Action>/hat/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
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
                    ""groups"": ""Gamepad"",
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
                    ""groups"": ""Gamepad"",
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
                    ""groups"": ""Gamepad"",
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
                    ""groups"": ""Gamepad"",
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
                    ""groups"": ""Keyboard&Mouse"",
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
                    ""groups"": ""Gamepad"",
                    ""action"": ""Special"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""988a2bcf-7e9d-4712-881b-61c597a57886"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
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
                    ""groups"": ""Gamepad"",
                    ""action"": ""GrabStop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6492d3df-6580-41e4-b87e-f9a7f31a423b"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
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
                    ""type"": ""Button"",
                    ""id"": ""5c7898c3-baa7-4710-9d65-017a09448eb0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Button"",
                    ""id"": ""b9ffe607-5976-47fd-a1e5-a90f9c6b1de7"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""d95977ef-dd8a-4f73-95f1-175062794ca1"",
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
                    ""id"": ""bfb8bb67-2f14-4127-afdb-292346fa62fa"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
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
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
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
        },
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
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
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
    public struct RobotActions
    {
        private @PlayerInput m_Wrapper;
        public RobotActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Robot_Move;
        public InputAction @Aim => m_Wrapper.m_Robot_Aim;
        public InputAction @Shoot => m_Wrapper.m_Robot_Shoot;
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
            }
        }
    }
    public RobotActions @Robot => new RobotActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
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
    }
}
