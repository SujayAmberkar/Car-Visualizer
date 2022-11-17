using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteriorCameraMouseController : MonoBehaviour
{
   [SerializeField] private Camera cam;

    [SerializeField] float cameraSpeed = 10f;
    private Vector3 previousPosition;
    
    Vector3 camInitialPos;
    Quaternion camInitialRot;
    float camInitialZoom;

    void Start() {
           camInitialPos = cam.transform.position;
           camInitialRot = cam.transform.rotation;
           camInitialZoom = cam.fieldOfView;    
    }


    // Update is called once per frame
    void Update()
    {
        cameraMovements();
    }

    void cameraMovements(){
        if (Input.GetMouseButtonDown(0))
        {
            previousPosition = cam.ScreenToViewportPoint(Input.mousePosition);
        }
        else if (Input.GetMouseButton(0))
        {
            Vector3 newPosition = cam.ScreenToViewportPoint(Input.mousePosition);
            Vector3 direction = previousPosition - newPosition;
            
            float rotationAroundYAxis = -direction.x * 180; // camera moves horizontally
            float rotationAroundXAxis = direction.y * 180; // camera moves vertically
            
            
            cam.transform.Rotate(new Vector3(1, 0, 0), rotationAroundXAxis);
            cam.transform.Rotate(new Vector3(0, 1, 0), rotationAroundYAxis, Space.World); 
            
            
            previousPosition = newPosition;
        }
        cam.fieldOfView -= Input.GetAxis("Mouse ScrollWheel") * cameraSpeed;
    }
}
