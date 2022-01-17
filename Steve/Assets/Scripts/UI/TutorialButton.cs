using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TutorialButton : MonoBehaviour
{
    private Renderer meshRenderer;
    [SerializeField] private GameObject tutorial;

    public Color colorOG;
    public Color colorHover;


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

    public void OpenTutorial()
    {
        if(tutorial.activeSelf)
            tutorial.SetActive(false);
        else
            tutorial.SetActive(true);
    }
}
