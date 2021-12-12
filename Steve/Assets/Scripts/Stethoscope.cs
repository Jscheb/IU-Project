using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stethoscope : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    public void PlayHeartBeat()
    {
        Debug.Log("Duhduh (Heartbeat noises)");
        audioSource.Play();
    }
}
