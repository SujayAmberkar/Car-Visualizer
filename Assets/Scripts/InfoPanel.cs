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
        data.Add("Tyre","This is Tyre");
        data.Add("Hood","This is hood");
        data.Add("Bumper","This is Bumper");
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
