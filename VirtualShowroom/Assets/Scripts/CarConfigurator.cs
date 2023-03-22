using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarConfigurator : MonoBehaviour
{
    /*check if camera is within zone car
     *check if it s looking from the outside or inside
     */
    private TriggerActionsCamera tac;

    void Start()
    {
        tac = GameObject.Find("Main Camera").GetComponent<TriggerActionsCamera>();
    }

    void Update()
    {
        if (tac.triggerZone == "TriggerCar")
        {
            Debug.Log("zone car");
        }
    }
}
