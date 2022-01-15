using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GraphicDisplayScript : MonoBehaviour
{
    [SerializeField] private GameObject leftScreen, secondLeftScreen,rightScreen,leftTooltip;
    [SerializeField] private List<GameObject> content;
    [SerializeField] private GameObject leftbutton, rightbutton;
    [SerializeField] int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        leftScreen.SetActive(false);
        rightScreen.SetActive(false);
        secondLeftScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RightButtonClick()
    {
        Debug.Log("Riught Arrow");
        if(i < content.Count-1)
        {
            content[i++].SetActive(false);
            content[i].SetActive(true);
        }
        else
        {
            content[i].SetActive(false);
            i = 0;
            content[i].SetActive(true);
        }
        
    }

    public void LeftButtonClick()
    {
        if (i > 0)
        {
            content[i--].SetActive(false);
            content[i].SetActive(true);
        }
        else
        {
            content[i].SetActive(false);
            i = content.Count-1;
            content[i].SetActive(true);
        }
    }

    public void ActivateLeftScreen()
    {
        leftScreen.SetActive(true);
    }

    public void ActivateRightScreen()
    {
        rightScreen.SetActive(true);
    }

    public void ActivateLeftScreenTwice()
    {
        leftScreen.SetActive(false);
        secondLeftScreen.SetActive(true);
    }

    public void ActivateLeftTooltip()
    {
        if(leftTooltip != null)
            leftTooltip.SetActive(true);
    }

    public void DeactivateLeftTooltip()
    {
        if (leftTooltip != null)
            leftTooltip.SetActive(false);
    }
}
