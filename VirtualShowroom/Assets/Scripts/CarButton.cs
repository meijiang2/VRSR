using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CarButton : MonoBehaviour
{
    public bool isConfOpen = false;
    public bool isOutsideCar;

    public CinemachineVirtualCamera camMainOnPath;
    public CinemachineVirtualCamera camCarConf;
    public CinemachineVirtualCamera camCarInterior;

    void Start()
    {
    }

    void Update()
    {
    }

    public void OpenCarConf()
    {
        isConfOpen = true;
        //open configurator
        //switch van camera?
        SwitchToCarCamConf();
    }
    public void CloseCarConf()
    {
        isConfOpen = false;
        //close configurator
        //switch back to main camera?
        CameraSwitcher.SwitchCamera(camMainOnPath);
    }

    public void SwitchToCarCamConf()
    {
        isOutsideCar = true;
        CameraSwitcher.SwitchCamera(camCarConf);
    }

    public void SwitchToCarCamInterior()
    {
        isOutsideCar = false;
        CameraSwitcher.SwitchCamera(camCarInterior);
    }
}
