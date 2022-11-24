using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InfoPanelPosition : MonoBehaviour
{
    public Camera cam;
    public GameObject ui;
    Transform panelPosition;
    Dictionary<string,string> data = new Dictionary<string,string>();
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI contentText;

    void Start() {
        data.Add("Tyre","This is Tyre");
        data.Add("Hood","This is hood");
        data.Add("Bumper","This is Bumper");
    }

    void Update()
    {
        if(panelPosition){
            Vector3 screenPos = cam.WorldToScreenPoint(panelPosition.position);
            transform.position = new Vector2(screenPos.x,screenPos.y);
        }
        if(Input.GetMouseButtonDown(0) && ui.activeSelf){
            ui.SetActive(false);
        }
    }

    public void SetPanelPosition(Transform iconPosition){
        panelPosition = iconPosition;
    }

    public void ShowPanel(string key){
        ui.SetActive(true);
        titleText.SetText(key);
        contentText.SetText(data[key]);
    }
    

    
}
