using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarConfigurator : MonoBehaviour
{
    /*check if camera is within zone car
     *check if it s looking from the outside or inside
     */
    //kan nog de carRotation script hierin samenvoegen

    private TriggerActionsCamera tac;
    private Vector3 standardPos;
    private Quaternion standardRot;
    public GameObject car;
    public GameObject carUI;
    public CarButton carButton;
    public Button openCarConfButton;
    public Button closeCarConfButton;
    public Button camCarConfButton;
    public Button camCarInteriorButton;
    public GameObject carConfUI;

    void Awake()
    {
        tac = Camera.main.GetComponent<TriggerActionsCamera>();
        standardPos = car.transform.position;
        standardRot = car.transform.rotation;
    }
    void Update()
    {
        if (tac.triggerZone == "TriggerCar")
        {
            carUI.SetActive(true);

            if (carButton.isConfOpen == true)
            {
                openCarConfButton.gameObject.SetActive(false);
                closeCarConfButton.gameObject.SetActive(true);

                carConfUI.SetActive(true);

                if (carButton.isOutsideCar == true)
                {
                    camCarConfButton.gameObject.SetActive(false);
                    camCarInteriorButton.gameObject.SetActive(true);


                }
                else
                {
                    camCarConfButton.gameObject.SetActive(true);
                    camCarInteriorButton.gameObject.SetActive(false);

                    
                }
            }
            else
            {
                openCarConfButton.gameObject.SetActive(true);
                closeCarConfButton.gameObject.SetActive(false);

                carConfUI.SetActive(false);
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
        car.transform.position = standardPos;
        car.transform.rotation = standardRot;
    }

    private void ResetCarUI()
    {
        carButton.isConfOpen = false;
        carUI.SetActive(false);
    }
}
