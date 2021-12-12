using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.Events;

public class TimerController : MonoBehaviour
{
    [SerializeField] private TMP_Text timer;
    [SerializeField] private int seconds;
    [SerializeField] private int minutes;

    public UnityEvent onEnd;

    // Start is called before the first frame update
    void Start()
    {
        timer.text = minutes + ":" + seconds;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartCountdown()
    {
        StartCoroutine("Countdown");
    }

    public IEnumerator Countdown()
    {
        while (minutes != 0 || seconds != 0)
        {
            seconds--;
            if (seconds < 0)
            {
                minutes--;
                seconds = 59;
            }
            if(seconds < 10)
                timer.text = minutes + ":0" + seconds;
            else
                timer.text = minutes + ":" + seconds;
            yield return new WaitForSeconds(1);
        }
        Debug.Log("End Countdown");
        onEnd.Invoke();
        yield return null;
    }
}
