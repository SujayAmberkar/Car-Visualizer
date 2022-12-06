using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusCameraMovement : MonoBehaviour
{
    [SerializeField] private Camera cam;
    Transform TargetTransform;
    Transform InfoIcon;
    bool CamerIsAtTargetPosition=true;
    float cameraSpeed = 3f;
  
    void Update()
    {
        // if camera is not at target position move towards target position and look at icon
        if(!CamerIsAtTargetPosition){
            cam.transform.position = Vector3.MoveTowards(cam.transform.position,TargetTransform.position, cameraSpeed * Time.deltaTime);
            cam.transform.LookAt(InfoIcon);

            // if camera is at target position 
            if(cam.transform.position==TargetTransform.position){
                CamerIsAtTargetPosition = true;
            }
        }
    }

    // get new target position and set it to global variable "newTransform" and set bool to false
    public void MoveCameraTo(Transform targetTransform){
        TargetTransform = targetTransform;
        CamerIsAtTargetPosition = false;    
    }

    // get targetted rotation to look at
    public void RotateCameraTo(Transform LookPoint){
        InfoIcon = LookPoint;
    }
}
