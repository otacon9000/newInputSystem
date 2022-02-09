using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private PlayerInputAction _input;
    // Start is called before the first frame update
    void Start()
    {
        _input = new PlayerInputAction();
        _input.Player.Enable();

        _input.Player.Movement.performed += Movement_performed;
    }

    private void Movement_performed(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        Debug.Log($"x: {context.ReadValue<Vector2>().x}, y: {context.ReadValue<Vector2>().y }");

        var move = context.ReadValue<Vector2>();
        transform.Translate(move * Time.deltaTime * 10f);
    }

    // Update is called once per frame
    void Update()
    {
        //poll or check input readings
    }
}
