using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodSample : MonoBehaviour
{
    public bool bloodTaken = false;
    private bool transparent = true;


    public int getBloodValues()
    {
        //Return Values or set local public variable, that can be accessed after a timer completed for checking the blood sample
        return 120;
    }

    public void setCoordinates(float x, float y, float z)
    {
        //Change coordinates when model position is changes
    }


    void setTransparency ()
    {
        //cube is only shown when VR Controller hovers over is or something 
        if(!transparent)
        {
            //TODO
            //set Transparency to false and make it invisible
        } else
        {
            //TODO
            //set Transparency to true and make it visible
        }
    }
    
}