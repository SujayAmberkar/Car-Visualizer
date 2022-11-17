using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    // List<GameObject> Parts = new List<GameObject>();
    Color[] colors = {Color.red,Color.white,Color.gray};
    GameObject[] Parts;
    Color color;
    TextMesh warning;

    void Start(){
        Parts = Parts = GameObject.FindGameObjectsWithTag("Chasis");
    }

    public void ChooseColor(int Inputcolor){
        color = colors[Inputcolor];
        if(Parts!=null){
            foreach (var part in Parts)
            {
                ChangeColor(color,part);
            }
        }
        
    }

    public void findPartsWithTag(string tag){
        Parts = GameObject.FindGameObjectsWithTag(tag);
    }

    public void ChangeColor(Color color,GameObject carPart){
            carPart.GetComponent<MeshRenderer>().material.SetColor("_Color",color);
    }
}
