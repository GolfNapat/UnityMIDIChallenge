using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    Keyinput inputActions;

    private bool a_Input;
    private bool s_Input;
    private bool d_Input;
    private bool f_Input;
    private bool g_Input;
    private bool h_Input;
    private bool space_Input;

    public bool a_Flag;
    public bool s_Flag;
    public bool d_Flag;
    public bool f_Flag;
    public bool g_Flag;
    public bool h_Flag;
    public bool space_Flag;

    public bool gameStart;

    private void Awake()
    {
        inputActions = new Keyinput();
        gameStart = true;

        inputActions.KeyNote.A.started += aKeyInput;
        inputActions.KeyNote.A.canceled += aKeyInput;

        inputActions.KeyNote.S.started += sKeyInput;
        inputActions.KeyNote.S.canceled += sKeyInput;

        inputActions.KeyNote.D.started += dKeyInput;
        inputActions.KeyNote.D.canceled += dKeyInput;

        inputActions.KeyNote.F.started += fKeyInput;
        inputActions.KeyNote.F.canceled += fKeyInput;

        inputActions.KeyNote.G.started += gKeyInput;
        inputActions.KeyNote.G.canceled += gKeyInput;

        inputActions.KeyNote.H.started += hKeyInput;
        inputActions.KeyNote.H.canceled += hKeyInput;

        inputActions.KeyNote.SpaceBar.started += spaceKeyInput;
        inputActions.KeyNote.SpaceBar.canceled += spaceKeyInput;
    }

    private void aKeyInput(InputAction .CallbackContext context)
    {
        switch (context .phase)
        {
            case InputActionPhase.Started:
                a_Input = true;
                break;

            case InputActionPhase.Canceled:
                a_Input = false;
                break;
        }
    }

    private void sKeyInput(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                s_Input = true;
                break;

            case InputActionPhase.Canceled:
                s_Input = false;
                break;
        }
    }

    private void dKeyInput(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                d_Input = true;
                break;

            case InputActionPhase.Canceled:
                d_Input = false;
                break;
        }
    }

    private void fKeyInput(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                f_Input = true;
                break;

            case InputActionPhase.Canceled:
                f_Input = false;
                break;
        }
    }

    private void gKeyInput(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                g_Input = true;
                break;

            case InputActionPhase.Canceled:
                g_Input = false;
                break;
        }
    }

    private void hKeyInput(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                h_Input = true;
                break;

            case InputActionPhase.Canceled:
                h_Input = false;
                break;
        }
    }

    private void spaceKeyInput(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                space_Input = true;
                break;

            case InputActionPhase.Canceled:
                space_Input = false;
                break;
        }
    }

    public void KeyInputHandler()
    {
        if(a_Input)
        {
            a_Flag = true;
        }
        else
        {
            a_Flag = false;
        }

        if(s_Input)
        {
            s_Flag = true;
        }
        else
        {
            s_Flag = false;
        }

        if(d_Input)
        {
            d_Flag = true;
        }
        else
        {
            d_Flag = false;
        }

        if (f_Input)
        {
            f_Flag = true;
        }
        else
        {
            f_Flag = false;
        }

        if (g_Input)
        {
            g_Flag = true;
        }
        else
        {
            g_Flag = false;
        }

        if(h_Input)
        {
            h_Flag = true;
        }
        else
        {
            h_Flag = false;
        }

        if(space_Input)
        {
            space_Flag = true;
        }
        else
        {
            space_Flag = false;
        }
    }

    private void OnEnable()
    {
        inputActions.KeyNote.Enable();
    }

    private void OnDisable()
    {
        inputActions.KeyNote.Disable();
    }
}
