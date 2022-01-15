using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class BloodSample : MonoBehaviour
{
    public bool bloodTakenOnce = false;
    public bool bloodTakenTwice = false;
    public bool cooldown = false;
    private bool transparent = true;
    public UnityEvent onBloodTaken;
    public UnityEvent onBloodTakenTwice;
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
        if(!bloodTakenOnce)
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
            bloodTakenOnce = true;
        }
        else if(bloodTakenOnce && !bloodTakenTwice && !cooldown)
        {
            Syringe sample = other.GetComponent<Syringe>();
            if (sample != null)
            {
                Debug.Log("Blood sample wurde genommen but again");
                onBloodTakenTwice.Invoke();

                if (GameObject.Find("LeftHand Controller").GetComponent<XRRayInteractor>().interactablesSelected.Contains(other.GetComponent<XRGrabInteractable>()))
                    StartCoroutine(Buzz(0));
                if (GameObject.Find("RightHand Controller").GetComponent<XRRayInteractor>().interactablesSelected.Contains(other.GetComponent<XRGrabInteractable>()))
                    StartCoroutine(Buzz(1));
            }
            bloodTakenTwice = true;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        cooldown = true;
        StartCoroutine(CoolDown());
    }

    private IEnumerator CoolDown()
    {
        yield return new WaitForSeconds(10f);
        cooldown = false;
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
