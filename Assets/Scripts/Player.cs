using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private PlayerInputAction _input;
    private MeshRenderer _mesh;

    void Start()
    {
        _input = new PlayerInputAction();
        _input.Player.Enable();
        _input.Player.ChangeColor.performed += ChangeColor_performed;


        _mesh = GetComponent<MeshRenderer>();
    }

    private void ChangeColor_performed(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        if(_mesh != null)
            _mesh.material.color = Random.ColorHSV();

    }

    void Update()
    {
        CalculateMovement();

        //var rotateDirection = _input.Player.Rotate.ReadValue<float>();
        //transform.Rotate(Vector3.up * Time.deltaTime * 30f * rotateDirection );
    }

    void CalculateMovement()
    {
        //poll or check input readings
        Vector2 move = _input.Player.Movement.ReadValue<Vector2>();

        transform.Translate(new Vector3(0, 0, move.y) * Time.deltaTime * 5f);

        transform.Rotate(Vector3.up * Time.deltaTime * 30f * move.x);
    }
}
