using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class BloodSample : MonoBehaviour
{
    public bool bloodTaken = false;
    private bool transparent = true;
    public UnityEvent onBloodTaken;
    private AudioClip test;

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

                if (GameObject.Find("LeftHand Controller").GetComponent<XRRayInteractor>().interactablesSelected.Contains(other.GetComponent<XRGrabInteractable>()))
                    StartCoroutine(Buzz(0));
                if (GameObject.Find("RightHand Controller").GetComponent<XRRayInteractor>().interactablesSelected.Contains(other.GetComponent<XRGrabInteractable>()))
                    StartCoroutine(Buzz(1));
            }
            bloodTaken = true;
        }
        
    }

    private IEnumerator Buzz(int i)
    {
        if(i == 0)
        {
            Haptics.singleton.leftactive = true;
            yield return new WaitForSeconds(0.1f);
            Haptics.singleton.leftactive = false;
        }
        else
        {
            Haptics.singleton.rightactive = true;
            yield return new WaitForSeconds(0.1f);
            Haptics.singleton.rightactive = false;
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
