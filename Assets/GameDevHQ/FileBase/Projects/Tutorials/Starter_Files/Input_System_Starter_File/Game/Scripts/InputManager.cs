using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Scripts.Player;
using Game.Scripts.LiveObjects;

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
    [SerializeField]
    private Player _player;
    [SerializeField]
    private Drone _drone;

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
   
    }

    private void DroneToPlayer_performed(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        _input.Drone.Disable();
        _input.Player.Enable();
        _drone.ExitFlightMode();

    }

    private void Interact_canceled(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        Debug.Log("HoldAction ended");
    }

    private void Interact_performed(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        Debug.Log("HoldAction ended");
    }

    private void Detonate_performed(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        Debug.Log("HoldAction ended");
    }

    private void Update()
    {
        //only for test 
        if (Input.GetKeyDown(KeyCode.U))
        {
            _input.Player.Disable();
            _input.Drone.Enable();
        }

        MovePlayer();
        MoveDrone();
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
        Debug.Log("drone Move: " + move);
        _drone.CalculateMoveTilt(move.x, move.y);

        float rotate = _input.Drone.Rotate.ReadValue<float>();
        _drone.CalculateRotation(rotate);
    }

    public void ThrustDrone()
    {
        float thrust = _input.Drone.Thrust.ReadValue<float>();
        _drone.CalculateThrust(thrust);
    }
}



