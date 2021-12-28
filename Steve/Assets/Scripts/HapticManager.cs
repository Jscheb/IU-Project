using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HapticManager : MonoBehaviour
{
    public static HapticManager singleton;

    // Start is called before the first frame update
    void Start()
    {
        if (singleton && singleton != this)
            Destroy(this);
        else
            singleton = this;
    }

   public void TriggerHapticFeedback(ActionBasedController controller)
    {
        if(controller != null)
        {
            Debug.Log("brrrrr");
            Debug.Log(controller.SendHapticImpulse(0.5f, 1f));
        }
        
    }
}
