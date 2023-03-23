using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarConfButton : MonoBehaviour
{
    public bool isConfOpen = false;


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
    }
    public void CloseCarConf()
    {
        isConfOpen = false;
        //close configurator
        //switch back to main camera?
    }
}
