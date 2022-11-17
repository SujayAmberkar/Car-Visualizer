using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiCameraSetup : MonoBehaviour
{
    public GameObject InteriorCam;
    public GameObject ExteriorCam;

    void Start()
    {
        InteriorCam.SetActive(false);
    }


    public void InteriorView(){
        InteriorCam.SetActive(true);
        ExteriorCam.SetActive(false);
    }

    public void ExteriorView(){
        InteriorCam.SetActive(false);
        ExteriorCam.SetActive(true);
    }
}
