using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.XR;

public class Haptics : MonoBehaviour
{
    public static Haptics singleton;
    public bool leftactive, rightactive;
    public UnityEngine.InputSystem.InputActionReference leftPosAction, rightPosAction;
    public UnityEngine.InputSystem.InputActionReference leftRotAction, rightRotAction;

    public float _amplitude = 1.0f;
    public float _duration = 1f;

    public float leftAmplitude = 1.0f;
    public float rightAmplitude = 1.0f;

    void Start()
    {
        if (singleton && singleton != this)
            Destroy(this);
        else
            singleton = this;

        leftAmplitude = _amplitude;
        rightAmplitude = _amplitude;

        leftPosAction.action.Enable();
        leftPosAction.action.performed += (ctx) =>
        {
            // If the action that was performed was on a XRController device then rumble
            if (ctx.control.device is XRController device)
                if (leftactive)
                    RumbleLeft(device);
        };
        rightPosAction.action.Enable();
        rightPosAction.action.performed += (ctx) =>
        {
            // If the action that was performed was on a XRController device then rumble
            if (ctx.control.device is XRController device)
                if (rightactive)
                    RumbleRight(device);
        };
        leftRotAction.action.Enable();
        leftRotAction.action.performed += (ctx) =>
        {
            // If the action that was performed was on a XRController device then rumble
            if (ctx.control.device is XRController device)
                if (leftactive)
                    RumbleLeft(device);
        };
        rightRotAction.action.Enable();
        rightRotAction.action.performed += (ctx) =>
        {
            // If the action that was performed was on a XRController device then rumble
            if (ctx.control.device is XRController device)
                if (rightactive)
                    RumbleRight(device);
        };
    }

    /// <summary>
    /// Send a rumble command to a device
    /// </summary>
    /// <param name="device">Device to send rumble to</param>
    public void Rumble(UnityEngine.InputSystem.InputDevice device)
    {
        // Setting channel to 1 will work in 1.1.1 but will be fixed in future versions such that 0 would be the correct channel.
        var channel = 1;
        var command = UnityEngine.InputSystem.XR.Haptics.SendHapticImpulseCommand.Create(channel, _amplitude, _duration);
        device.ExecuteCommand(ref command);
    }

    /// <summary>
    /// Function that demonstrates rumbling the right hand controller 
    /// </summary>
    public void RumbleRight(UnityEngine.InputSystem.InputDevice device)
    {
        // Setting channel to 1 will work in 1.1.1 but will be fixed in future versions such that 0 would be the correct channel.
        var channel = 1;
        var command = UnityEngine.InputSystem.XR.Haptics.SendHapticImpulseCommand.Create(channel, rightAmplitude, _duration);
        device.ExecuteCommand(ref command);
    }

    /// <summary>
    /// Function that demonstrates rumbling the left hand controller 
    /// </summary>
    public void RumbleLeft(UnityEngine.InputSystem.InputDevice device)
    {
        // Setting channel to 1 will work in 1.1.1 but will be fixed in future versions such that 0 would be the correct channel.
        var channel = 1;
        var command = UnityEngine.InputSystem.XR.Haptics.SendHapticImpulseCommand.Create(channel, leftAmplitude, _duration);
        device.ExecuteCommand(ref command);
    }
}
