using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{

   
    //1. get reference and start an instance of our input 
    [SerializeField]
    private PlayerInputAction _input;

    private void Start()
    {
        _input = new PlayerInputAction();
        //2. enable input action map (dog)
        _input.Dog.Enable();
        //3. register perform function 
        _input.Dog.Bark.performed += Bark_performed;
        _input.Dog.Walk.performed += Walk_performed;
        _input.Dog.Run.performed += Run_performed;
        _input.Dog.Run.canceled += Run_canceled;
        _input.Dog.Die.performed += Die_performed;
    }

    private void Die_performed(InputAction.CallbackContext context)
    {
        Debug.Log("Die: " + context);
    }

    private void Run_performed(InputAction.CallbackContext context)
    {
        Debug.Log("Run:" + context);
    }   
    private void Run_canceled(InputAction.CallbackContext context)
    {
        Debug.Log("Run ended:" + context);
    }

    private void Walk_performed(InputAction.CallbackContext context)
    {
        Debug.Log("Walking: " + context);
    }

    private void Bark_performed(InputAction.CallbackContext context)
    {
        Debug.Log("Barking..." + context);
    }
}
