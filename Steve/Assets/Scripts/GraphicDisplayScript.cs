using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GraphicDisplayScript : MonoBehaviour
{
    [SerializeField] private GameObject leftScreen,rightScreen,leftTooltip; 

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

    public void ActivateLeftTooltip()
    {
        leftTooltip.SetActive(true);
    }

    public void DeactivateLeftTooltip()
    {
        leftTooltip.SetActive(false);
    }
}
