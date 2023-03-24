using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarConfigurator : MonoBehaviour
{
    //kan nog de carRotation script hierin samenvoegen

    private TriggerActionsCamera tac;

    private Vector3 stdPos;
    private Quaternion stdRot;

    //car ui values
    #region
    public GameObject car;
    public GameObject carUI;
    public CarButton carButton;
    public Button openCarConfButton;
    public Button closeCarConfButton;
    public Button camCarConfButton;
    public Button camCarInteriorButton;
    public GameObject carConfUI;
    public CarChangePreset changePreset;
    #endregion

    void Awake()
    {
        tac = Camera.main.GetComponent<TriggerActionsCamera>();
        stdPos = car.transform.position;
        stdRot = car.transform.rotation;
        //stdBodyMats = stdBodyMeshRend.sharedMaterials;
        //stdDoorMats = stdDoorMeshRend.sharedMaterials;
        //stdDoorHandleMat = stdDoorHandleMeshRend.material;
        //stdSeatMat = stdSeatMeshRend.material;
        //stdSteeringWheelMat = stdSteeringWheelMeshRend.material;
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
        car.transform.position = stdPos;
        car.transform.rotation = stdRot;

        //stdBodyMeshRend.sharedMaterials = stdBodyMats;
        //stdDoorMeshRend.sharedMaterials = stdDoorMats;
        //stdDoorHandleMeshRend.material = stdDoorHandleMat;
        //stdSeatMeshRend.material = stdSeatMat;
        //stdSteeringWheelMeshRend.material = stdSteeringWheelMat;

        changePreset.ChangeCarToP1();
    }

    private void ResetCarUI()
    {
        carButton.isConfOpen = false;
        carUI.SetActive(false);
    }
}
