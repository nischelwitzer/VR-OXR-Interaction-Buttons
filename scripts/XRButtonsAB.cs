using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class XRButtonsAB : MonoBehaviour
{
    private XRIDefaultInputActions myXRInput;

    void Awake()
    {
        Debug.Log("XRButtonsAB awake");

        myXRInput = new XRIDefaultInputActions();
        myXRInput.Enable();
        myXRInput.XRIRightHandInteraction.ButtonA.performed += xrButtonA;
    }

    private void xrButtonA(InputAction.CallbackContext context)
    {
        Debug.Log("XRButtonA pressed");
    }
}
