using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSphere : MonoBehaviour
{
    private PlayerInputAction _input;
    private bool _jumped = false;

    private void OnEnable()
    {
        _input = new PlayerInputAction();
        _input.SpherePlayer.Enable();
        _input.SpherePlayer.Jump.performed += Jump_performed;
        _input.SpherePlayer.Jump.canceled += Jump_canceled;

    }

    private void Jump_canceled(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        var forceValue = context.duration;
        GetComponent<Rigidbody>().AddForce(Vector3.up * (10f * (float)forceValue), ForceMode.Impulse);
    }

    private void Jump_performed(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        Debug.Log("Jump");
        GetComponent<Rigidbody>().AddForce(Vector3.up * 10f, ForceMode.Impulse);
    }
}
