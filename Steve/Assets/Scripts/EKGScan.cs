using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

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
            Debug.Log("Ekg is being taken");
            Debug.Log(other);
            EKGProbe sample = other.GetComponent<EKGProbe>();
            if (sample != null)
            {
                Debug.Log("EKG wurde genommen");
                sample.DisableMovement();
                onEKGTaken.Invoke();

                if (GameObject.Find("LeftHand Controller").GetComponent<XRRayInteractor>().interactablesSelected.Contains(other.GetComponent<XRGrabInteractable>()))
                    StartCoroutine(Buzz(0));
                if (GameObject.Find("RightHand Controller").GetComponent<XRRayInteractor>().interactablesSelected.Contains(other.GetComponent<XRGrabInteractable>()))
                    StartCoroutine(Buzz(1));
            }
            ekgTaken = true;
        }

    }

    private IEnumerator Buzz(int i)
    {
        if (i == 0)
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
