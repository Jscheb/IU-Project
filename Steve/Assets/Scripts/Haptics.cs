using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.XR;

public class Haptics : MonoBehaviour
{
    public static Haptics singleton;
    public UnityEngine.InputSystem.InputActionReference action;
    public float _amplitude = 1.0f;
    public float _duration = 1f;
    
    void Start()
    {
        if (singleton && singleton != this)
            Destroy(this);
        else
            singleton = this;
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            // If the action that was performed was on a XRController device then rumble
            if (ctx.control.device is XRController device)
                Rumble(device);
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
    public void RumbleRight()
    {
        UnityEngine.InputSystem.InputSystem.GetDevice<XRController>(UnityEngine.InputSystem.CommonUsages.RightHand);
    }

    /// <summary>
    /// Function that demonstrates rumbling the left hand controller 
    /// </summary>
    public void RumbleLeft()
    {
        Debug.Log("Left Hand"+UnityEngine.InputSystem.InputSystem.GetDevice<XRController>());
        var leftHanded = new List<UnityEngine.XR.InputDevice>();

        UnityEngine.XR.InputDevices.GetDevicesWithRole(UnityEngine.XR.InputDeviceRole.LeftHanded, leftHanded);
        foreach (var device in leftHanded)
        {
            HapticCapabilities capabilities;
            if (device.TryGetHapticCapabilities(out capabilities))
            {
                if (capabilities.supportsImpulse)
                {
                    uint channel = 0;
                    float amplitude = 0.5f;
                    float duration = 1.0f;
                    device.SendHapticImpulse(channel, amplitude, duration);
                }
            }
        }
            
    }
}
