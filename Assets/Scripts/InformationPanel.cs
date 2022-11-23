using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InformationPanel : MonoBehaviour
{

    public GameObject InfoPanel;

    void Start() {
            
    }

    void Update(){
        
        if (Input.GetMouseButtonDown(0)){
            // InfoPanel.SetActive(false);
        }

    }

    public void showPanel(){
        InfoPanel.SetActive(true);
    }

}
