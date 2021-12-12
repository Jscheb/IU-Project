using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LeftPanel : MonoBehaviour
{
    public UnityEvent onStart;
    private Renderer meshRenderer;
    [SerializeField] private bool startCountdown = false;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<Renderer>();
        meshRenderer.material.color = Color.red;
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
        meshRenderer.material.color = Color.red*1.5f;
    }

    public void ReactToHoverStop()
    {
        meshRenderer.material.color = Color.red;
    }

    public void StartProgram()
    {
        onStart.Invoke();
    }
}
