using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GraphicDisplayScript : MonoBehaviour
{
    [SerializeField] private GameObject leftScreen,rightScreen,leftTooltip;
    [SerializeField] private List<GameObject> content;
    [SerializeField] private GameObject leftbutton, rightbutton;
    int i = 0;

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

    public void RightButtonClick()
    {
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

    public void ActivateLeftTooltip()
    {
        leftTooltip.SetActive(true);
    }

    public void DeactivateLeftTooltip()
    {
        leftTooltip.SetActive(false);
    }
}
