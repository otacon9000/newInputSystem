using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Scripts.Player;

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
        MovePlayer();   
    }

    public void MovePlayer()
    {
        Vector2 move = _input.Player.Movement.ReadValue<Vector2>();
        _player.CalcutateMovement(move.x, move.y);
    }


}
