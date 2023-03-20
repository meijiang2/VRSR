using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WatchInfo : MonoBehaviour
{
    private string selectedName = "empty";
    private TriggerActionsCamera tac;
    private SelectionManager selectionManager;
    //private GameObject[] infoTexts;
    private GameObject infoBG;
    private GameObject info1;
    private GameObject info2;
    private GameObject info3;

    void Start()
    {
        selectionManager = GameObject.Find("SelectionManager").GetComponent<SelectionManager>();
        tac = GameObject.Find("Main Camera").GetComponent<TriggerActionsCamera>();
        //infoTexts = GameObject.FindGameObjectsWithTag("WatchInfo");
        infoBG = GameObject.Find("WIBG");
        info1 = GameObject.Find("WI1");
        info2 = GameObject.Find("WI2");
        info3 = GameObject.Find("WI3");
    }

    void Update()
    {
        if (selectionManager.selectedGO != null)
        {
            selectedName = selectionManager.selectedGO.name;
        }
        else
        {
            selectedName = "empty";
        }
        if (tac.triggerZone == "TriggerWatch")
        {
            ShowWatchInfo(selectedName);
        }
    }

    private void ShowWatchInfo(string goName)
    {
        //Debug.Log(goName);
        switch (goName)
        {
            case "Backcircle":
                //iets
                //Debug.Log("BAckcircle 1 ");
                infoBG.SetActive(true);
                info1.SetActive(true);
                break;
            case "BatteryBaked":
                //iets
                break;
            case "Casing":
                //iets
                //Debug.Log("Casing 2 ");
                infoBG.SetActive(true);
                info2.SetActive(true);
                break;
            case "ChipBaked":
                //iets
                //Debug.Log("Chipbaked 3 ");
                infoBG.SetActive(true);
                info3.SetActive(true);
                break;
            case "Display":
                //iets
                break;
            case "Screen":
                //iets
                break;
            case "ScreenOutlineBaked":
                //iets
                break;
            case "Sidebutton":
                //iets
                break;
            case "Speaker":
                //iets
                break;
            case "Taptic_Engine_ModuleBaked":
                //iets
                break;
            case "Wheel":
                //iets
                break;
            case "empty":
                infoBG.SetActive(false);
                info1.SetActive(false);
                info2.SetActive(false);
                info3.SetActive(false);
                break;
            default:
                
                break;
        }
    }
}
