using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Scripts.Player;
using Game.Scripts.LiveObjects;
using Game.Scripts.UI;

public class InputManager : MonoBehaviour
{
    private static InputManager _instance;
    public static InputManager Instance 
    {
        get
        {
            if (_instance == null)
                Debug.Log("InputManager is NULL");

            return _instance;
        }
    }

    
    private GameInputs _input;
    [Header("Input Controllers")]
    [SerializeField]
    private Player _player;
    [SerializeField]
    private Drone _drone;
    [SerializeField]
    private Laptop _laptop;
    [SerializeField]
    private Forklift _forkLift;

    [Header("InteractablZone")]
    [SerializeField]
    private InteractableZone _c4Zone;
    [SerializeField]
    private InteractableZone _placeC4Zone;
    [SerializeField]
    private InteractableZone _detonateZone;
    [SerializeField]
    private InteractableZone _hackingZone;
    [SerializeField]
    private InteractableZone _droneZone;
    [SerializeField]
    private InteractableZone _forkLiftZone;
    [SerializeField]
    private InteractableZone _blockZone;
    [SerializeField]
    private InteractableZone _endZone;

    private void Awake()
    {
        _instance = this;
    }

    private void Start()
    {
        _input = new GameInputs();
        _input.Player.Enable();
        _input.Player.Detonate.performed += Detonate_performed;
        _input.Player.Interact.performed += Interact_performed;
        _input.Player.Interact.canceled += Interact_canceled;

        _input.Drone.DroneToPlayer.performed += DroneToPlayer_performed;

        //_input.ForkLift.LiftDown.canceled += LiftDown_performed;
        //_input.ForkLift.LiftUp.canceled += LiftUp_performed;
        _input.ForkLift.ForkLiftToPlayer.performed += ForkLiftToPlayer_performed;
   
    }

    private void ForkLiftToPlayer_performed(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        _input.ForkLift.Disable();
        _input.Player.Enable();
        _forkLift.ExitDriveMode();
    }

    //private void LiftUp_performed(UnityEngine.InputSystem.InputAction.CallbackContext context)
    //{
    //    _forkLift.LiftUpRoutine();
    //}

    //private void LiftDown_performed(UnityEngine.InputSystem.InputAction.CallbackContext context)
    //{
    //    _forkLift.LiftDownRoutine();
    //}

    private void DroneToPlayer_performed(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        _input.Drone.Disable();
        _input.Player.Enable();
        _drone.ExitFlightMode();

    }

    private void Interact_canceled(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
       
        if (InteractableZone.CurrentZoneID >= 3)
        {
            _laptop.InteractableZone_onHoldEnded(InteractableZone.CurrentZoneID);
            //InteractableZone.Instance.DisableMarker();
            //UIManager.Instance.DisplayInteractableZoneMessage(false);
        }
    }

    private void Interact_performed(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        
        
        switch (InteractableZone.CurrentZoneID)
        {
            case 0:
                Debug.Log("Case interactable: 0 ");
                _c4Zone.CollectItems();
                _c4Zone.EndCollect();
                _c4Zone.DisableMarker();
                break;
            case 1:
                Debug.Log("Case interactable: 1");
                _placeC4Zone.PerformAction();
                _placeC4Zone.EndPerformed();
                _placeC4Zone.DisableMarker();
                break;
            case 2:
                break;
            case 3:
                Debug.Log("Case interactable: 3");
                _laptop.InteractableZone_onHoldStarted(InteractableZone.CurrentZoneID);

                _hackingZone.DisableMarker();

                UIManager.Instance.DisplayInteractableZoneMessage(false);
                break;
            case 4:
                Debug.Log("Case interactable: 4");
                UIManager.Instance.DisplayInteractableZoneMessage(false);
                _input.Player.Disable();
                _input.Drone.Enable();
                _droneZone.PerformAction();
                _droneZone.DisableMarker();
                break;
            case 5:
                Debug.Log("Case interactable: 5");
                _input.Player.Disable();
                _input.ForkLift.Enable();
                _forkLiftZone.PerformAction();
                _forkLiftZone.DisableMarker();
                break;


        }
        }

    private void Detonate_performed(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        Debug.Log("HoldAction ended");
        if (InteractableZone.CurrentZoneID == 2)
        {
            _detonateZone.PerformAction();
            _detonateZone.EndPerformed();
            _detonateZone.DisableMarker();
        }
    }

    private void Update()
    {

        MovePlayer();
        MoveDrone();
        if (InteractableZone.CurrentZoneID == 6)
        {
            MoveForkLift();
            ControlLift();
        }
    }

    private void FixedUpdate()
    {
        ThrustDrone();
    }

    public void MovePlayer()
    {
        Vector2 move = _input.Player.Movement.ReadValue<Vector2>();
        _player.CalcutateMovement(move.x, move.y);
    }

    public void MoveDrone()
    {
       
        Vector2 move = _input.Drone.Movement.ReadValue<Vector2>();
        _drone.CalculateMoveTilt(move.x, move.y);

        float rotate = _input.Drone.Rotate.ReadValue<float>();
        _drone.CalculateRotation(rotate);
    }

    public void ThrustDrone()
    {
        float thrust = _input.Drone.Thrust.ReadValue<float>();
        _drone.CalculateThrust(thrust);
    }

    public void MoveForkLift()
    {
        Vector2 move = _input.ForkLift.Movement.ReadValue<Vector2>();
        _forkLift.CalcutateMovement(move.x, move.y);
    }

    public void ControlLift()
    {
        float value = _input.ForkLift.LiftControls.ReadValue<float>();
        _forkLift.LiftControls(value);

    }


}



