using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusCameraMovement : MonoBehaviour
{
    [SerializeField] private Camera cam;
    Transform t;
    bool a=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(a){
            cam.transform.position = Vector3.MoveTowards(cam.transform.position,t.position, 60 * Time.deltaTime);
        }
        
        
    }

    public void MoveCameraTo(Transform newPosition){
        t = newPosition;
        a = true;
        // transform.position = Vector3.Lerp(transform.position, newPosition.position, Time.deltaTime);
    }
}
