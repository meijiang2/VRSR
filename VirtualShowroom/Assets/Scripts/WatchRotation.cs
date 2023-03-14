using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WatchRotation : MonoBehaviour
{
    private Vector3 watchRotation;
    private float speed = 2f;
    private TriggerActionsCamera tac;
    private Button openWatchButton;

    void Start()
    {
        watchRotation.y = 10;
        tac = GameObject.Find("Main Camera").GetComponent<TriggerActionsCamera>();
        openWatchButton = GameObject.Find("OpenWatch").GetComponent<Button>();
    }

    void Update()
    {
        transform.Rotate(watchRotation * speed * Time.deltaTime);

        if (tac.isInTriggerZone)
        {
            openWatchButton.gameObject.SetActive(true);
        }
        else
        {
            openWatchButton.gameObject.SetActive(false);
        }

        //if (Input.GetMouseButton(0))
        //{
        //    transform.eulerAngles += speed * new Vector3(x: -Input.GetAxis("Mouse Y"), y: Input.GetAxis("Mouse X"), z: 0);
        //}
    }
}
