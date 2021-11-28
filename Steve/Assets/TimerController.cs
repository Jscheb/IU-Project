using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class TimerController : MonoBehaviour
{
    [SerializeField] private TMP_Text timer;
    [SerializeField] private int seconds;
    [SerializeField] private int minutes;

    // Start is called before the first frame update
    void Start()
    {
        timer.text = minutes + ":" + seconds;
        StartCoroutine("Countdown");
    }

    // Update is called once per frame
    void Update()
    {
        
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

            timer.text = minutes + ":" + seconds;
            yield return new WaitForSeconds(1);
        }
        yield return null;
    }
}
