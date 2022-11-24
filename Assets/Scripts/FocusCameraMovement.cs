using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusCameraMovement : MonoBehaviour
{
    [SerializeField] private Camera cam;
    Transform newTransform;
    Transform InfoIcon;
    bool CamerIsAtPosition=true;
    float cameraSpeed = 10f;
  
    void Update()
    {
        // if camera is not at target position move towards target position and look at icon
        if(!CamerIsAtPosition){
            cam.transform.position = Vector3.MoveTowards(cam.transform.position,newTransform.position, cameraSpeed * Time.deltaTime);
            cam.transform.LookAt(InfoIcon);

            // if camera is at target position 
            if(cam.transform.position==newTransform.position){
                CamerIsAtPosition = true;
            }
        }
    }

    // get new target position and set it to global variable "newTransform" and set bool to false
    public void MoveCameraTo(Transform targetTransform){
        newTransform = targetTransform;
        CamerIsAtPosition = false;    
    }

    // get targetted rotation to look at
    public void RotateCameraTo(Transform targetRotation){
        InfoIcon = targetRotation;
    }
}
