using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        Rigidbody rbdy = gameObject.GetComponent<Rigidbody>();

        //Stop Moving/Translating
        rbdy.isKinematic = true;
    }
}
