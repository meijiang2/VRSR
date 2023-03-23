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
    public GameObject carUI;

    public Button openCarConfButton;
    public Button closeCarConfButton;
    public CarConfButton ccb;
    public GameObject carConfUI;


    void Start()
    {
        tac = Camera.main.GetComponent<TriggerActionsCamera>();

    }
    void Update()
    {
        if (tac.triggerZone == "TriggerCar")
        {
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
            ResetCar();
            ResetCarUI();
        }
    }

    private void ResetCar()
    {

        //kan nog de carRotation script hierin samenvoegen
    }

    private void ResetCarUI()
    {
        ccb.isConfOpen = false;
        carUI.SetActive(false);
    }
}
