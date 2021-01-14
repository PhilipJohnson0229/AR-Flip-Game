using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public bool k_input;

    PlayerControls inputActions;

    public void OnEnable()
    {
        if (inputActions == null)
        {
            inputActions = new PlayerControls();
        }

        inputActions.Enable();
    }

    public void TickInput(float delta)
    {
        HandleKickInput();
        if (k_input) { Debug.Log("test"); }
    }

    public void HandleKickInput()
    {
        //inputActions.PlayerAction.Kick.performed += i => k_input = true;
        if (Input.GetKeyDown(KeyCode.Space)) { k_input = true; }
    }

}
