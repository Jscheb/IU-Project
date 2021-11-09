using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestKollision : MonoBehaviour
{
    public GameObject cube;
    private bool spawned = false;


    private void OnTriggerEnter(Collider other)
    {
        if (!spawned)
        {
            TestActivateKollision e = other.GetComponent<TestActivateKollision>();
            if (e != null)
            {
                GameObject objectGameObject = Instantiate(cube) as GameObject;
                objectGameObject.transform.position = e.transform.position + new Vector3(2.0f,2.0f,2.0f);
                spawned = true;
            }

        }
        
    }

    // Update is called once per frame  
    void Update()
    {
        
    }
}
