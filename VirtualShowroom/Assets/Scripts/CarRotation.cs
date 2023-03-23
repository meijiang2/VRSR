using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarRotation : MonoBehaviour
{
    private float speed = 2f;
    private TriggerActionsCamera tac;

    void Start()
    {
        tac = Camera.main.GetComponent<TriggerActionsCamera>();
    }

    void Update()
    {
        if (tac.triggerZone == "TriggerCar")
        {
            RotateCar();
        }
        else
        {
            transform.eulerAngles = new Vector3(x: 0, y: 0, z: 0);
        }
    }

    private void RotateCar()
    {
        if (Input.GetMouseButton(0))
        {
            transform.eulerAngles += speed * new Vector3(x: 0, y: Input.GetAxis("Mouse X"), z: 0);
        }
    }
}
