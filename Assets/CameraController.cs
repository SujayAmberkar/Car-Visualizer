using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Camera cam;
    public GameObject InteriorCam;
    public GameObject ExteriorCam;
    float cameraSpeed = 10f;
    void Start()
    {
        InteriorCam.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(cam.fieldOfView<35 || cam.fieldOfView>22) {
            cam.fieldOfView -= Input.GetAxis("Mouse ScrollWheel") * cameraSpeed;
        }
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
