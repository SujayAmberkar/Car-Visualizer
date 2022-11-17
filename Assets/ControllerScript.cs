using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    float Speed=20f;

    // Update is called once per frame
    void Update()
    {
        float clockWise = Input.GetAxis("Horizontal") * Speed*Time.deltaTime;
        transform.Rotate(0,clockWise,0);

    }
}
