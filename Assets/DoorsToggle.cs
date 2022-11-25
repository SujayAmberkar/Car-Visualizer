using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorsToggle : MonoBehaviour
{
    bool doorOpen = false;
    public GameObject door1;
    public GameObject door2;
    int angle;

    // Update is called once per frame
    void Update()
    {
        if(doorOpen){
            angle = 45;
        }else{
            angle = 0;
        }
               door1. transform.rotation = Quaternion.Slerp (door1.transform.rotation, Quaternion.Euler (new Vector3(0,angle,0)), 1f * Time.deltaTime);
               door2. transform.rotation = Quaternion.Slerp (door2.transform.rotation, Quaternion.Euler (new Vector3(0,-angle,0)), 1f * Time.deltaTime); 
        
    }
        

    public void OpenDoors(bool open){
        doorOpen = open;
    }
}
