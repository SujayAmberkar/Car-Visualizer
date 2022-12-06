using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmosScript : MonoBehaviour
{

    public Camera cameraToLookAt;
  

    void Update()
    {
            // direction vector from camera towards icon
            Vector3 v = cameraToLookAt.transform.position - transform.position;
            // distance between camera and icon
            float distance = Vector3.Distance(cameraToLookAt.transform.position,transform.position);
            v.x = v.z = 0.0f;
            transform.LookAt( cameraToLookAt.transform.position - v );
            if(distance>2){
                transform.Rotate(0,180,0); 
            }      
    }
}
