using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WatchRotation : MonoBehaviour
{
    private Vector3 watchRotation;
    private float speed = 2f;
    private TriggerActionsCamera tac;
    private SelectionManager selectionManager;
    private Button openWatchButton;
    private Vector3 standardRotation;
    private Vector3 currentRotation;

    void Start()
    {
        watchRotation.y = 10;
        tac = GameObject.Find("Main Camera").GetComponent<TriggerActionsCamera>();
        selectionManager = GameObject.Find("SelectionManager").GetComponent<SelectionManager>();
        openWatchButton = GameObject.Find("OpenWatch").GetComponent<Button>();
        standardRotation = transform.eulerAngles;
    }

    void Update()
    {
        transform.Rotate(watchRotation * speed * Time.deltaTime);

        if (/*tac.isInTriggerZone && */tac.triggerZone == "TriggerWatch")
        {
            Debug.Log("test message");
            openWatchButton.gameObject.SetActive(true);
            if (Input.GetMouseButton(0))
            {
                transform.eulerAngles += speed * new Vector3(x: -Input.GetAxis("Mouse Y"), y: Input.GetAxis("Mouse X"), z: 0);
                currentRotation = transform.eulerAngles;
            }
        }
        else
        {
            openWatchButton.gameObject.SetActive(false);
            if (currentRotation != standardRotation)
            {
                transform.eulerAngles = standardRotation; //werkt maar snapt naar die positie
                //transform.Rotate(standardRotation); //werkt niet: voert t wel uit maar  ziet het niet
                currentRotation = standardRotation;

                //hier code voor sluit anim
            }
            
        }
    }
}
