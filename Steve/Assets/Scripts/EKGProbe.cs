using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class EKGProbe : MonoBehaviour
{
    private bool stop;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DisableMovement()
    {
        XRGrabInteractable grabby = gameObject.GetComponent<XRGrabInteractable>();
        Destroy(grabby);

        Rigidbody rbdy = gameObject.GetComponent<Rigidbody>();

        //Stop Moving/Translating

        Destroy(rbdy);

        
    }
}
