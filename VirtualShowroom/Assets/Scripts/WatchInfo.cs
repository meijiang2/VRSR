using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WatchInfo : MonoBehaviour
{
    private string selectedName = "empty";
    private TriggerActionsCamera tac;
    private SelectionManager selectionManager;
    private GameObject infoBG;
    private GameObject info1;
    private GameObject info2;
    private GameObject info3;

    void Start()
    {
        selectionManager = GameObject.Find("SelectionManager").GetComponent<SelectionManager>();
        tac = GameObject.Find("Main Camera").GetComponent<TriggerActionsCamera>();
        infoBG = GameObject.Find("WIBG");
        info1 = GameObject.Find("WI1");
        info2 = GameObject.Find("WI2");
        info3 = GameObject.Find("WI3");
    }

    void Update()
    {
        if (tac.triggerZone == "TriggerWatch")
        {
            if (selectionManager.selectedGO != null)
            {
                selectedName = selectionManager.selectedGO.name;
            }
            else
            {
                selectedName = "empty";
            }
            
            ShowWatchInfo(selectedName);
        }
        else
        {
            selectedName = "empty";
            DisactivateAllInfo();
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
                info2.SetActive(false);
                info3.SetActive(false);
                break;
            case "BatteryBaked":
                //iets
                break;
            case "Casing":
                //iets
                //Debug.Log("Casing 2 ");
                infoBG.SetActive(true);
                info2.SetActive(true);
                info1.SetActive(false);
                info3.SetActive(false);
                break;
            case "ChipBaked":
                //iets
                //Debug.Log("Chipbaked 3 ");
                infoBG.SetActive(true);
                info3.SetActive(true);
                info1.SetActive(false);
                info2.SetActive(false);
                break;
            case "Display":
                //iets
                Debug.Log("Nog geen actie toegevoegd...");
                break;
            case "Screen":
                //iets
                Debug.Log("Nog geen actie toegevoegd...");
                break;
            case "ScreenOutlineBaked":
                //iets
                Debug.Log("Nog geen actie toegevoegd...");
                break;
            case "Sidebutton":
                //iets
                Debug.Log("Nog geen actie toegevoegd...");
                break;
            case "Speaker":
                //iets
                Debug.Log("Nog geen actie toegevoegd...");
                break;
            case "Taptic_Engine_ModuleBaked":
                //iets
                Debug.Log("Nog geen actie toegevoegd...");
                break;
            case "Wheel":
                //iets
                Debug.Log("Nog geen actie toegevoegd...");
                break;
            case "empty":
                DisactivateAllInfo();
                break;
            default:
                
                break;
        }
    }

    private void DisactivateAllInfo()
    {
        infoBG.SetActive(false);
        info1.SetActive(false);
        info2.SetActive(false);
        info3.SetActive(false);
    }
}
