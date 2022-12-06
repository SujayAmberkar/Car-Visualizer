using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InfoPanel : MonoBehaviour
{
    // variable declaration
    public Camera cam;
    public GameObject ui;
    Transform iconPosition;
    Dictionary<string,string> data = new Dictionary<string,string>();
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI contentText;

    void Start() {
        // Add title and content in a dictionary "data"
        data.Add("Tyre","Pirelli tires for the Maserati are a perfect marriage of technology and innovation, made with a special tread compound that can tackle any weather condition without hesitation.");
        data.Add("Engine","The F136, commonly known as Ferrari-Maserati engine, is a family of 90° V8 petrol engines");
        data.Add("Park Assist"," Surround View Camera assists you during parking maneuvers by combining all the information provided by 4 cameras placed around your vehicle.");
        ui.SetActive(false);
    }

    void Update()
    {
        // set panel position if icon position exists
        if(iconPosition){
            Vector3 screenPos = cam.WorldToScreenPoint(iconPosition.position);
            transform.position = new Vector2(screenPos.x,screenPos.y);
        }
        // hide panel on mouse click
        if(Input.GetMouseButtonDown(0) && ui.activeSelf){
            ui.SetActive(false);
        }
    }


    public void SetPanelPosition(Transform InputIconPosition){
        iconPosition = InputIconPosition;
    }

    // show panel and assign title and content from dictionary
    public void ShowPanel(string key){
        ui.SetActive(true);
        titleText.SetText(key);
        contentText.SetText(data[key]);
    }
    

    
}
