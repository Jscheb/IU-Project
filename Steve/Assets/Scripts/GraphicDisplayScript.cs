using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GraphicDisplayScript : MonoBehaviour
{
    [SerializeField] private GameObject leftScreen,rightScreen; 

    // Start is called before the first frame update
    void Start()
    {
        leftScreen.SetActive(false);
        rightScreen.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateLeftScreen()
    {
        leftScreen.SetActive(true);
    }

    public void ActivateRightScreen()
    {
        rightScreen.SetActive(true);
    }
}
