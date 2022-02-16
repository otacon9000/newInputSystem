using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private PlayerInputAction _input;
    private MeshRenderer _mesh;

    private void OnEnable()
    {
        _input = new PlayerInputAction();
        _input.Player.Enable();
        _input.Player.ChangeColor.performed += ChangeColor_performed;
        _input.Player.DrivingState.performed += DrivingState_performed;

        _input.Driving.PlayerState.performed += PlayerState_performed;
    }



    void Start()
    {
        _mesh = GetComponent<MeshRenderer>();
    }

    private void DrivingState_performed(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        Debug.Log("Switch to Driving");
        _input.Player.Disable();
        _input.Driving.Enable();
    }

    private void PlayerState_performed(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        Debug.Log("Switch to Player");
        _input.Driving.Disable();
        _input.Player.Enable();

    }

    private void ChangeColor_performed(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        if(_mesh != null)
            _mesh.material.color = Random.ColorHSV();

    }

    void Update()
    {
        CalculateMovement();

        CalculateMovementDriving();

        //var rotateDirection = _input.Player.Rotate.ReadValue<float>();
        //transform.Rotate(Vector3.up * Time.deltaTime * 30f * rotateDirection );
    }

    void CalculateMovement()
    {
        Vector2 move = _input.Player.Movement.ReadValue<Vector2>();

        transform.Translate(new Vector3(0, 0, move.y) * Time.deltaTime * 5f);

        transform.Rotate(Vector3.up * Time.deltaTime * 30f * move.x);
    }

    void CalculateMovementDriving()
    {
        Vector2 move = _input.Driving.Movement.ReadValue<Vector2>();

        transform.Translate(new Vector3(move.x, 0, move.y) * Time.deltaTime * 5f);
    }
}
