using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

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

                if (GameObject.Find("LeftHand Controller").GetComponent<XRRayInteractor>().interactablesSelected.Contains(other.GetComponent<XRGrabInteractable>()))
                    StartCoroutine(Buzz(0));
                if (GameObject.Find("RightHand Controller").GetComponent<XRRayInteractor>().interactablesSelected.Contains(other.GetComponent<XRGrabInteractable>()))
                    StartCoroutine(Buzz(1));
            }
        heartbeatScanned = true;
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
