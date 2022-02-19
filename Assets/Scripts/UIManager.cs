using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Slider _slider;

    private InputActionPlayer _input;
    private bool _isPressed = false;

    private void OnEnable()
    {
        _input = new InputActionPlayer();
        _input.UIMap.Enable();
        _input.UIMap.FillBar.performed += FillBar_performed;
        _input.UIMap.FillBar.canceled += FillBar_canceled;
    }

    private void FillBar_canceled(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        _isPressed = false;   
    }

    private void FillBar_performed(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        _isPressed = true;
    }

    private void Update()
    {
        if (_isPressed)
        {
            _slider.value += 0.05f * Time.deltaTime;
        }
        else
        {
            _slider.value -= 0.1f * Time.deltaTime;
        }
    }
}
