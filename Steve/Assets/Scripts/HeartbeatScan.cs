using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HeartbeatScan : MonoBehaviour
{
    public bool heartbeatScanned = false;
    private bool transparent = true;
    public UnityEvent onheartbeatScanned;

    public void getHeartbeat()
    {
        //Return the heartbeat somehow
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!heartbeatScanned) { 
            Stethoscope sample = other.GetComponent<Stethoscope>();
        if (sample != null)
        {
            Debug.Log("Heartbeat wurde gesteroscopiert jaaa");
                onheartbeatScanned.Invoke();
        }
        heartbeatScanned = true;
        }
    }

    public void setTransparency()
    {
        //cube is only shown when VR Controller hovers over is or something 
        if (!transparent)
        {
            //TODO
            //set Transparency to false and make it invisible
            transparent = true;
            gameObject.SetActive(false);
        }
        else
        {
            //TODO
            //set Transparency to true and make it visible
            transparent = false;
            gameObject.SetActive(true);
        }
    }

}
