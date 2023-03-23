using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarConfigurator : MonoBehaviour
{
    /*check if camera is within zone car
     *check if it s looking from the outside or inside
     */
    private TriggerActionsCamera tac;
    private GameObject carUI;

    private Button openCarConfButton;
    private Button closeCarConfButton;
    private CarConfButton ccb;
    private GameObject carConfUI;

    //private ApplyColor applyColor;


    void Start()
    {
        tac = GameObject.Find("Main Camera").GetComponent<TriggerActionsCamera>();
        carUI = GameObject.Find("UICar");

        openCarConfButton = GameObject.Find("OpenCarConf").GetComponent<Button>();
        closeCarConfButton = GameObject.Find("CloseCarConf").GetComponent<Button>();
        ccb = gameObject.GetComponent<CarConfButton>();
        carConfUI = GameObject.Find("CarConf");

    }
    //error: applyColor.carMaterial bestaat niet
    void Update()
    {
        if (tac.triggerZone == "TriggerCar")
        {
            //Debug.Log(gameObject.GetComponent<CarConfButton>());
            carUI.SetActive(true);

            if (ccb.isConfOpen == false)
            {
                openCarConfButton.gameObject.SetActive(true);
                closeCarConfButton.gameObject.SetActive(false);

                carConfUI.SetActive(false);
            }
            else
            {
                openCarConfButton.gameObject.SetActive(false);
                closeCarConfButton.gameObject.SetActive(true);

                carConfUI.SetActive(true);
            }
        }
        else
        {
            //Debug.Log(applyColor.carMaterial);
            ResetCar();
            ResetCarUI();
        }
    }

    private void ResetCar()
    {
        //Debug.Log(applyColor.carMaterial);
        //applyColor.carMaterial.color = Color.white;

        //kan nog de carRotation script hierin samenvoegen
    }

    private void ResetCarUI()
    {
        ccb.isConfOpen = false;
        carUI.SetActive(false);
    }
}
