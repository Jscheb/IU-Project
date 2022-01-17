using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPanel : MonoBehaviour
{
    [SerializeField] private List<GameObject> content;
    [SerializeField] private GameObject leftbutton, rightbutton;
    [SerializeField] public int i = 0;

    public Color colorOG;
    public Color colorHover;
    private Renderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ReactToHoverStart()
    {
        meshRenderer.material.color = colorHover * 1.5f;
    }

    public void ReactToHoverStop()
    {
        meshRenderer.material.color = colorOG;
    }

    public void RightButtonClick()
    {
        Debug.Log("Riught Arrow");
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
        Debug.Log("Left Arrow");
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
