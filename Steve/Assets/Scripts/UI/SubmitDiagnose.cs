using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmitDiagnose : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject spray1,spray2;

    public void Dubmit()
    {
        if(panel.GetComponent<RightPanel>().i == 1){
            spray1.GetComponent<ParticleSystem>().Play();
            spray2.GetComponent<ParticleSystem>().Play();
            GetComponent<AudioSource>().Play();
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
