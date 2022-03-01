// GENERATED AUTOMATICALLY FROM 'Assets/GameDevHQ/FileBase/Projects/Tutorials/Starter_Files/Input_System_Starter_File/Game/Scripts/Input/GameInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GameInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInputs"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""6b15d4f0-7034-47e9-8fe1-cdf0d15500f2"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""67859fcd-e2ee-4e7a-a07d-e0c3fa8a4c28"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""72b9b1f4-2a3d-402a-af6f-a84d19c2ac83"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Detonate"",
                    ""type"": ""Button"",
                    ""id"": ""f7c949df-484b-491e-964d-cf47bd65e8fd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""6d3f72ae-7817-46b9-be6b-f147206171b6"",
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
                    ""id"": ""8066c54c-19dc-4a7b-825c-8ef45916709c"",
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
                    ""id"": ""f4db9b2d-4fe3-4e04-8263-b0f8c407515e"",
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
                    ""id"": ""76c0ce55-2fc5-4cbc-8575-ccbe1665a289"",
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
                    ""id"": ""f87f052e-9cf9-461e-8670-4bf4ca26ea10"",
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
                    ""id"": ""fb0b4a35-f74e-407a-8ae5-dc942526aee6"",
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
                    ""id"": ""ead500a1-379f-4534-9e73-972df7cbf72f"",
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
                    ""id"": ""355225a8-23bc-4b59-81b6-a0f8a3fadd1a"",
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
                    ""id"": ""c7f2c7ae-7865-43b6-9899-4d7fdda67bc3"",
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
                    ""id"": ""51178fd0-e950-4d99-b571-aedfb41d29e7"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftStick"",
                    ""id"": ""6d6dc7a5-f216-4553-ba87-781dd56e2ae8"",
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
                    ""id"": ""81a34a81-e0be-4934-8a69-8ac2dd22c520"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""19f8100e-95ae-4e90-bb84-7ec5220bf15a"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c7c51d2b-7b53-445d-bb55-3dfc51d111eb"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f28845e0-db8b-4e3b-9c3b-f6d1de648cfc"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0c33d1aa-5b81-4830-b024-99cad415d175"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Press,Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d5d7aafa-654b-4731-a731-cbf55ee6fb8d"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": ""Press,Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""71aea3a3-b0d9-4640-afd4-14e9ca3456ee"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Detonate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""090cda00-871e-4182-813d-107ab1a914a5"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Detonate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Drone"",
            ""id"": ""45ee546d-af28-44fc-8b40-26e02c864846"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""d4dcef60-7c19-4773-b6a2-b433218bc6aa"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Button"",
                    ""id"": ""a1958792-da27-4942-9074-3fe55e5d4f41"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Thrust"",
                    ""type"": ""Button"",
                    ""id"": ""bc9af0a4-8fe0-41da-9832-e19abd8219d6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DroneToPlayer"",
                    ""type"": ""Button"",
                    ""id"": ""27a908a9-c929-41e1-8d85-ce325656270a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""2efe51c5-e428-4fad-9a0c-33ca83b9296d"",
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
                    ""id"": ""8e1edc0a-a0b6-4040-93b5-c21b7a4f0b15"",
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
                    ""id"": ""115a074f-01e6-49d4-99d0-457d2c0d435c"",
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
                    ""id"": ""c9397121-dc5d-4874-b7d3-4115979a31f7"",
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
                    ""id"": ""51157530-9cf4-40bc-befd-ace95d1b3c37"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftStick"",
                    ""id"": ""3d00c12e-9e06-4af3-9490-800553f62ae6"",
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
                    ""id"": ""a2536cf6-aceb-4b9e-a228-f2f8dc7c5fff"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f25f41e3-eb14-4fef-b40a-0988664675e1"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""92b6d2ef-c535-4c95-bf48-de081885ac63"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2147c50f-1be3-41b7-9870-79c9c95c4e7b"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""a1aa540c-a21a-4c2d-94cf-fca5df8cf9fb"",
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
                    ""id"": ""cbe330e1-2865-4953-95e1-51ede7719701"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e8a51253-5779-4fe0-b862-8afd9563b8f2"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""517c70af-24f3-4753-ba1b-ffb4f4ddd014"",
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
                    ""id"": ""497ec64b-1040-4fa3-aa3d-d2d6c7b7df96"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""87fc1bfd-82d5-4d7e-97a5-b0ab2157b2ad"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Space&V"",
                    ""id"": ""41b095b3-4501-43d5-b760-7f2da8f39bff"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Thrust"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9655c1ee-5cb7-4711-ba81-fbe29cfa49bb"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Thrust"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""191c5f24-e485-4184-93b0-c80dffc353e1"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Thrust"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ControllerTrigger"",
                    ""id"": ""1d258a19-56e4-4dff-af04-0bd56ae2a614"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Thrust"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""44b9aefd-31c6-47bb-96f0-59c66c611e11"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Thrust"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""587f8e22-7a54-4e5f-a17a-6b9f6b565593"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Thrust"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""69252132-13d4-4f9d-8d6f-88af8d5691bd"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DroneToPlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""09bd0e38-3f4e-4033-a266-de5df28d0b38"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DroneToPlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""ForkLift"",
            ""id"": ""42dc2e88-c5fe-468c-92f9-980c085609a8"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""3386041e-6f84-49af-b0b5-39ed77fa802a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ForkLiftToPlayer"",
                    ""type"": ""Button"",
                    ""id"": ""88dd062d-1c88-47ad-8ab6-211bd1fd55fc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LiftControls"",
                    ""type"": ""Value"",
                    ""id"": ""c6df391d-7c8d-4575-b0b6-79bd2e56863c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""6088b6d5-96d6-4c23-be0b-2e6ffab032d4"",
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
                    ""id"": ""ad3be384-1570-4924-9309-a1d5d1e01552"",
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
                    ""id"": ""51e199b2-9abd-4dfc-bfe0-4f5b6b781fa5"",
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
                    ""id"": ""7ce92ffa-95bc-4032-925d-1ecd563101b1"",
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
                    ""id"": ""ed8b68d4-666b-4757-a6d4-df7056a956a6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftStick"",
                    ""id"": ""c5c2307e-ce5e-4cf9-a8c1-6a5b88c01e90"",
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
                    ""id"": ""bd501a2a-1248-475d-892f-13336cb435a7"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e4733e6f-0166-4172-b98b-e7f65a289edc"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c518caed-7653-4582-b3a0-00f9f47ce131"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""339d4a93-5d07-415a-9b98-92372dff2a1d"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""01d634e4-5c1f-4d2e-9742-31c5fc0c587e"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForkLiftToPlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""207edb94-3659-4663-beca-3436abb28dfa"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForkLiftToPlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keybord"",
                    ""id"": ""5847eaa0-a7f9-44d8-afde-6928da4c71d1"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LiftControls"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4dc84147-8b39-46ef-81cc-489ee3c5b6fb"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LiftControls"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8046c2f8-27f6-4d83-8a55-c3352a56fd59"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LiftControls"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""RightStick"",
                    ""id"": ""eecd04de-3fcf-408d-8898-9b11dde66232"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LiftControls"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""40a95998-bccc-4ade-a2be-c5980450fa9a"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LiftControls"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""13a1f65c-fd8a-4b24-ac3c-805fe5090f78"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LiftControls"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Laptop "",
            ""id"": ""ad9b9da7-0638-4312-9bcb-4dfc87d61dd9"",
            ""actions"": [
                {
                    ""name"": ""LaptopToPlayer"",
                    ""type"": ""Button"",
                    ""id"": ""349ad129-afa6-4a7d-9ed6-498500209ee1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeCamera"",
                    ""type"": ""Button"",
                    ""id"": ""7264bc40-9e3d-458a-96d4-e628c3d98c3f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""71a39dec-77b3-4a6a-811d-a3394d76d924"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LaptopToPlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""504976b2-c538-484f-a16b-f000fdc1ce23"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LaptopToPlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8fc4220d-b083-4a4b-9184-6e9e380be4ac"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b6f474d8-96c8-4ba0-b22c-02703441591d"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeCamera"",
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
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
        m_Player_Detonate = m_Player.FindAction("Detonate", throwIfNotFound: true);
        // Drone
        m_Drone = asset.FindActionMap("Drone", throwIfNotFound: true);
        m_Drone_Movement = m_Drone.FindAction("Movement", throwIfNotFound: true);
        m_Drone_Rotate = m_Drone.FindAction("Rotate", throwIfNotFound: true);
        m_Drone_Thrust = m_Drone.FindAction("Thrust", throwIfNotFound: true);
        m_Drone_DroneToPlayer = m_Drone.FindAction("DroneToPlayer", throwIfNotFound: true);
        // ForkLift
        m_ForkLift = asset.FindActionMap("ForkLift", throwIfNotFound: true);
        m_ForkLift_Movement = m_ForkLift.FindAction("Movement", throwIfNotFound: true);
        m_ForkLift_ForkLiftToPlayer = m_ForkLift.FindAction("ForkLiftToPlayer", throwIfNotFound: true);
        m_ForkLift_LiftControls = m_ForkLift.FindAction("LiftControls", throwIfNotFound: true);
        // Laptop 
        m_Laptop = asset.FindActionMap("Laptop ", throwIfNotFound: true);
        m_Laptop_LaptopToPlayer = m_Laptop.FindAction("LaptopToPlayer", throwIfNotFound: true);
        m_Laptop_ChangeCamera = m_Laptop.FindAction("ChangeCamera", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Interact;
    private readonly InputAction m_Player_Detonate;
    public struct PlayerActions
    {
        private @GameInputs m_Wrapper;
        public PlayerActions(@GameInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputAction @Detonate => m_Wrapper.m_Player_Detonate;
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
                @Interact.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Detonate.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDetonate;
                @Detonate.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDetonate;
                @Detonate.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDetonate;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Detonate.started += instance.OnDetonate;
                @Detonate.performed += instance.OnDetonate;
                @Detonate.canceled += instance.OnDetonate;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Drone
    private readonly InputActionMap m_Drone;
    private IDroneActions m_DroneActionsCallbackInterface;
    private readonly InputAction m_Drone_Movement;
    private readonly InputAction m_Drone_Rotate;
    private readonly InputAction m_Drone_Thrust;
    private readonly InputAction m_Drone_DroneToPlayer;
    public struct DroneActions
    {
        private @GameInputs m_Wrapper;
        public DroneActions(@GameInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Drone_Movement;
        public InputAction @Rotate => m_Wrapper.m_Drone_Rotate;
        public InputAction @Thrust => m_Wrapper.m_Drone_Thrust;
        public InputAction @DroneToPlayer => m_Wrapper.m_Drone_DroneToPlayer;
        public InputActionMap Get() { return m_Wrapper.m_Drone; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DroneActions set) { return set.Get(); }
        public void SetCallbacks(IDroneActions instance)
        {
            if (m_Wrapper.m_DroneActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnMovement;
                @Rotate.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnRotate;
                @Thrust.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnThrust;
                @Thrust.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnThrust;
                @Thrust.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnThrust;
                @DroneToPlayer.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnDroneToPlayer;
                @DroneToPlayer.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnDroneToPlayer;
                @DroneToPlayer.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnDroneToPlayer;
            }
            m_Wrapper.m_DroneActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @Thrust.started += instance.OnThrust;
                @Thrust.performed += instance.OnThrust;
                @Thrust.canceled += instance.OnThrust;
                @DroneToPlayer.started += instance.OnDroneToPlayer;
                @DroneToPlayer.performed += instance.OnDroneToPlayer;
                @DroneToPlayer.canceled += instance.OnDroneToPlayer;
            }
        }
    }
    public DroneActions @Drone => new DroneActions(this);

    // ForkLift
    private readonly InputActionMap m_ForkLift;
    private IForkLiftActions m_ForkLiftActionsCallbackInterface;
    private readonly InputAction m_ForkLift_Movement;
    private readonly InputAction m_ForkLift_ForkLiftToPlayer;
    private readonly InputAction m_ForkLift_LiftControls;
    public struct ForkLiftActions
    {
        private @GameInputs m_Wrapper;
        public ForkLiftActions(@GameInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_ForkLift_Movement;
        public InputAction @ForkLiftToPlayer => m_Wrapper.m_ForkLift_ForkLiftToPlayer;
        public InputAction @LiftControls => m_Wrapper.m_ForkLift_LiftControls;
        public InputActionMap Get() { return m_Wrapper.m_ForkLift; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ForkLiftActions set) { return set.Get(); }
        public void SetCallbacks(IForkLiftActions instance)
        {
            if (m_Wrapper.m_ForkLiftActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnMovement;
                @ForkLiftToPlayer.started -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnForkLiftToPlayer;
                @ForkLiftToPlayer.performed -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnForkLiftToPlayer;
                @ForkLiftToPlayer.canceled -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnForkLiftToPlayer;
                @LiftControls.started -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnLiftControls;
                @LiftControls.performed -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnLiftControls;
                @LiftControls.canceled -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnLiftControls;
            }
            m_Wrapper.m_ForkLiftActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @ForkLiftToPlayer.started += instance.OnForkLiftToPlayer;
                @ForkLiftToPlayer.performed += instance.OnForkLiftToPlayer;
                @ForkLiftToPlayer.canceled += instance.OnForkLiftToPlayer;
                @LiftControls.started += instance.OnLiftControls;
                @LiftControls.performed += instance.OnLiftControls;
                @LiftControls.canceled += instance.OnLiftControls;
            }
        }
    }
    public ForkLiftActions @ForkLift => new ForkLiftActions(this);

    // Laptop 
    private readonly InputActionMap m_Laptop;
    private ILaptopActions m_LaptopActionsCallbackInterface;
    private readonly InputAction m_Laptop_LaptopToPlayer;
    private readonly InputAction m_Laptop_ChangeCamera;
    public struct LaptopActions
    {
        private @GameInputs m_Wrapper;
        public LaptopActions(@GameInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @LaptopToPlayer => m_Wrapper.m_Laptop_LaptopToPlayer;
        public InputAction @ChangeCamera => m_Wrapper.m_Laptop_ChangeCamera;
        public InputActionMap Get() { return m_Wrapper.m_Laptop; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LaptopActions set) { return set.Get(); }
        public void SetCallbacks(ILaptopActions instance)
        {
            if (m_Wrapper.m_LaptopActionsCallbackInterface != null)
            {
                @LaptopToPlayer.started -= m_Wrapper.m_LaptopActionsCallbackInterface.OnLaptopToPlayer;
                @LaptopToPlayer.performed -= m_Wrapper.m_LaptopActionsCallbackInterface.OnLaptopToPlayer;
                @LaptopToPlayer.canceled -= m_Wrapper.m_LaptopActionsCallbackInterface.OnLaptopToPlayer;
                @ChangeCamera.started -= m_Wrapper.m_LaptopActionsCallbackInterface.OnChangeCamera;
                @ChangeCamera.performed -= m_Wrapper.m_LaptopActionsCallbackInterface.OnChangeCamera;
                @ChangeCamera.canceled -= m_Wrapper.m_LaptopActionsCallbackInterface.OnChangeCamera;
            }
            m_Wrapper.m_LaptopActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LaptopToPlayer.started += instance.OnLaptopToPlayer;
                @LaptopToPlayer.performed += instance.OnLaptopToPlayer;
                @LaptopToPlayer.canceled += instance.OnLaptopToPlayer;
                @ChangeCamera.started += instance.OnChangeCamera;
                @ChangeCamera.performed += instance.OnChangeCamera;
                @ChangeCamera.canceled += instance.OnChangeCamera;
            }
        }
    }
    public LaptopActions @Laptop => new LaptopActions(this);
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnDetonate(InputAction.CallbackContext context);
    }
    public interface IDroneActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnThrust(InputAction.CallbackContext context);
        void OnDroneToPlayer(InputAction.CallbackContext context);
    }
    public interface IForkLiftActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnForkLiftToPlayer(InputAction.CallbackContext context);
        void OnLiftControls(InputAction.CallbackContext context);
    }
    public interface ILaptopActions
    {
        void OnLaptopToPlayer(InputAction.CallbackContext context);
        void OnChangeCamera(InputAction.CallbackContext context);
    }
}
