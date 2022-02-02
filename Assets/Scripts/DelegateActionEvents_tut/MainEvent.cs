using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainEvent : MonoBehaviour
{
    public delegate void ActionClick();
    public static event ActionClick onClick;

    public delegate void TeleportAction(Vector3 pos);
    public static event TeleportAction onTeleport;

    public Vector3 cubePosition;

    public void ButtonClick()
    {

        if (onClick != null)
            onClick();

       
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (onTeleport != null)
                onTeleport(cubePosition);
        }
    }
}
