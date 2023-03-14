using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchRotation : MonoBehaviour
{
    private Vector3 watchRotation;
    private float speed = 2f;

    private TriggerActionsCamera tac;

    void Start()
    {
        watchRotation.y = 10;
        //tac = GameObject.Find("Main Camera").GetComponent<TriggerActionsCamera>();
    }

    void Update()
    {
        transform.Rotate(watchRotation * speed * Time.deltaTime);
        Debug.Log(tac.isInTriggerZone);
        //if (tac.isInTriggerZone)

        //if (Input.GetMouseButton(0))
        //{
        //    transform.eulerAngles += speed * new Vector3(x: -Input.GetAxis("Mouse Y"), y: Input.GetAxis("Mouse X"), z: 0);
        //}
    }
}
