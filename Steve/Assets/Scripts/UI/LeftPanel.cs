using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LeftPanel : MonoBehaviour
{
    public UnityEvent onStart;
    private Renderer meshRenderer;
    [SerializeField] private bool startCountdown = false;

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
        if (startCountdown)
        {
            Debug.Log("Start Countdown (Admin tool)");
            onStart.Invoke();
            startCountdown = false;
        }
    }

    public void ReactToHoverStart()
    {
        meshRenderer.material.color = colorHover * 1.5f;
    }

    public void ReactToHoverStop()
    {
        meshRenderer.material.color = colorOG;
    }

    public void StartProgram()
    {
        onStart.Invoke();
    }
}
