using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartbeatScan : MonoBehaviour
{
    public void getHeartbeat()
    {
        //Return the heartbeat somehow
    }

    private void OnTriggerEnter(Collider other)
    {
        Stethoscope sample = other.GetComponent<Stethoscope>();
        if (sample != null)
        {
            Debug.Log("Heartbeat wurde gesteroscopiert jaaa");
        }
    }

}
