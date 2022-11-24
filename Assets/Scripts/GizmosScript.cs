using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmosScript : MonoBehaviour
{

    public Camera cameraToLookAt;
  

    void Update()
    {
            Vector3 v = cameraToLookAt.transform.position - transform.position;
            float dist = Vector3.Distance(cameraToLookAt.transform.position,transform.position);
            v.x = v.z = 0.0f;
            transform.LookAt( cameraToLookAt.transform.position - v );
            if(dist>2){
                transform.Rotate(0,180,0); 
            }

            
                   
    }
}
