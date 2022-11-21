using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InformationPanel : MonoBehaviour
{
    public GameObject InfoPanel;

    Dictionary<string,string> data= new Dictionary<string,string>();

    public TextMeshProUGUI TitleText;
    public TextMeshProUGUI infoText;


    void Start()
    {
        InfoPanel.SetActive(false);
        data.Add("Hood","This is Hood");
        data.Add("Tyre","This is a tyre");
        data.Add("Bumper","This is a bumber");
    }

    void Update(){
        if (Input.GetMouseButtonDown(0)){
            InfoPanel.SetActive(false);
        }
    }

    public void showPanel(){
        InfoPanel.SetActive(true);
    }

    public void displayData(string title){
        infoText.text = data[title];
        TitleText.text = title;
    }

}
