using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillboardNameTag : MonoBehaviour
{

    public Transform textLookTargetTransform;
    [SerializeField] private float yOffset, xOffset = 0.01f, zOffset;
    // Start is called before the first frame update
    void Start()
    {
        FaceTextMeshToCamera();
        transform.position = transform.parent.position + new Vector3(xOffset, yOffset, zOffset);
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeSelf)
        {
            FaceTextMeshToCamera();
            transform.position = transform.parent.position + new Vector3(xOffset, yOffset, zOffset);
        }
    }

    public void Activate()
    {
        gameObject.SetActive(true);
    }

    public void Deactivate()
    {
        gameObject.SetActive(false);
    }

    void FaceTextMeshToCamera()
    {
        Vector3 origRot = gameObject.transform.eulerAngles;
        gameObject.transform.LookAt(textLookTargetTransform);
        Vector3 desiredRot = gameObject.transform.eulerAngles;
        //Fix x angel
        //desiredRot.x = origRot.x;
        //Fix z angle
        //desiredRot.z = origRot.z;
        gameObject.transform.eulerAngles = desiredRot;
    }
}
