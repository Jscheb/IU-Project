using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPanel : MonoBehaviour
{
    [SerializeField] private List<GameObject> content;
    [SerializeField] private GameObject leftbutton, rightbutton;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RightButtonClick()
    {
        if (i < content.Count - 1)
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
            i = content.Count - 1;
            content[i].SetActive(true);
        }
    }
}
