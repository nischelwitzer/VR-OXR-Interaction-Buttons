using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(AudioSource))]

public class XRButtonsAShot: MonoBehaviour
{
    private XRIDefaultInputActionsAIM myXRInput;

    public Transform dirShot;
    public float shotForce = 1000f;
    public Rigidbody waterPrefab;

    private AudioSource soundShot;

    void Awake()
    {
        Debug.Log("XRButtonsAB awake");

        myXRInput = new XRIDefaultInputActionsAIM();
        myXRInput.Enable();
        myXRInput.XRIRightHand.ButtonA.performed += xrButtonA;

        soundShot = this.gameObject.GetComponent<AudioSource>();
    }

    private void xrButtonA(InputAction.CallbackContext context)
    {
        myShot();
        Debug.Log("XRButtonA pressed");
    }

    private void myShot()
    {
        Rigidbody shot = Instantiate(waterPrefab, dirShot.position, dirShot.rotation) as Rigidbody;
        shot.AddForce(dirShot.forward * shotForce);
        soundShot.Play(); // to AudioSource
    }
}
