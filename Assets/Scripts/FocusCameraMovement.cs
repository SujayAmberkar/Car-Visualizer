using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusCameraMovement : MonoBehaviour
{
    [SerializeField] private Camera cam;
    Transform newTransform;
    Transform newRotation;
    bool CamerIsAtPosition=true;
    float cameraSpeed = 10f;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if(!CamerIsAtPosition){
            cam.transform.position = Vector3.MoveTowards(cam.transform.position,newTransform.position, cameraSpeed * Time.deltaTime);
            cam.transform.LookAt(newRotation);
            if(cam.transform.position==newTransform.position){
                CamerIsAtPosition = true;
            }
        }
    }

    public void MoveCameraTo(Transform targetTransform){
        newTransform = targetTransform;
        CamerIsAtPosition = false;    
    }

    public void RotateCameraTo(Transform targetRotation){
        newRotation = targetRotation;
    }
}
