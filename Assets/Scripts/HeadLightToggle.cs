using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadLightToggle : MonoBehaviour
{
    public Light[] lights;

    void Start() {
        foreach (var headLight in lights)
        {
            headLight.enabled = false;
        }
        
    }

    public void HeadLights(bool isOn){
        foreach (var headLight in lights)
        {
            headLight.enabled = isOn;
        }
    }
}
