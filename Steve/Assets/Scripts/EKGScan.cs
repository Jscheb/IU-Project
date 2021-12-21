using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EKGScan : MonoBehaviour
{
    public bool ekgTaken = false;
    private bool transparent = true;
    public UnityEvent onEKGTaken;

    public void setCoordinates(float x, float y, float z)
    {
        //Change coordinates when model position is changes
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!ekgTaken)
        {
            EKGProbe sample = other.GetComponent<EKGProbe>();
            if (sample != null)
            {
                Debug.Log("Blood sample wurde genommen");
                sample.DisableMovement();
                onEKGTaken.Invoke();
            }
            ekgTaken = true;
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
