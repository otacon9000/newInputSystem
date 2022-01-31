using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{

   
    //1. get reference and start an instance of our input 
    private PlayerInputAction _input;

    private void Start()
    {
        _input = new PlayerInputAction();
        //2. enable input action map (dog)
        _input.Dog.Enable();
        //3. register perform function 
        _input.Dog.Bark.performed += Bark_performed;
    }

    private void Bark_performed(InputAction.CallbackContext context)
    {
        Debug.Log("Barking..." + context);
    }
}
