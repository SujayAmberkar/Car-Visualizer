using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    Color[] colors = {Color.red,Color.white,Color.gray};
    GameObject[] Parts;
    Color color;

    void Start(){
        // Set chasis as default selected part
        Parts = GameObject.FindGameObjectsWithTag("Chasis");
    }

    // Select Car parts with same tag and put it in "Parts" array 
    // execute on click 
    public void findPartsWithTag(string tag){
        Parts = GameObject.FindGameObjectsWithTag(tag);
    }

    // Select color and call ChangeColor()
    public void ChooseColor(int Inputcolor){
        color = colors[Inputcolor];
        if(Parts!=null){
            foreach (var part in Parts)
            {
                ChangeColor(color,part);
            }
        }
        
    }

    // get selected colors and Selected parts and apply color to the every selected part
    public void ChangeColor(Color color,GameObject carPart){
            carPart.GetComponent<MeshRenderer>().material.SetColor("_Color",color);
    }
}
