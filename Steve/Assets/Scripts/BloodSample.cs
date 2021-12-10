using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BloodSample : MonoBehaviour
{
    public bool bloodTaken = false;
    private bool transparent = true;
    public UnityEvent onBloodTaken;


    public int getBloodValues()
    {
        //Return Values or set local public variable, that can be accessed after a timer completed for checking the blood sample
        return 120;

        //Or start timer
    }

    public void setCoordinates(float x, float y, float z)
    {
        //Change coordinates when model position is changes
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!bloodTaken)
        {
            Syringe sample = other.GetComponent<Syringe>();
            if (sample != null)
            {
                Debug.Log("Blood sample wurde genommen");
                onBloodTaken.Invoke();
            }
            bloodTaken = true;
        }
        
    }


    public void setTransparency ()
    {
        //cube is only shown when VR Controller hovers over is or something 
        if(!transparent)
        {
            //TODO
            //set Transparency to false and make it invisible
            transparent = true;
            gameObject.SetActive(false);
        } else
        {
            //TODO
            //set Transparency to true and make it visible
            transparent = false;
            gameObject.SetActive(true);
        }
    }
    
}
