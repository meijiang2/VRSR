using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WatchRotation : MonoBehaviour
{
    private Vector3 watchRotation;
    private float speed = 2f;
    private TriggerActionsCamera tac;
    public Button openWatchButton;
    public Button closeWatchButton;
    public WatchButton watchButton;

    void Start()
    {
        watchRotation.y = 10;
        tac = Camera.main.GetComponent<TriggerActionsCamera>();
    }

    void Update()
    {
        
        if (tac.triggerZone == "TriggerWatch")
        {
            if (watchButton.isOpenAnimPlayed == false)
            {
                openWatchButton.gameObject.SetActive(true);
                closeWatchButton.gameObject.SetActive(false);
            }
            else
            {
                openWatchButton.gameObject.SetActive(false);
                closeWatchButton.gameObject.SetActive(true);
            }
            if (Input.GetMouseButton(0))
            {
                transform.eulerAngles += speed * new Vector3(x: 0, y: Input.GetAxis("Mouse X"), z: 0);
            }
            else
            {
                WatchAutoRotate();
            }
        }
        else
        {
            WatchAutoRotate();
            if (watchButton.isOpenAnimPlayed)
            {
                watchButton.CloseWatch();
            }
            openWatchButton.gameObject.SetActive(false);
            closeWatchButton.gameObject.SetActive(false);
        }
    }

    private void WatchAutoRotate()
    {
        transform.eulerAngles += watchRotation * speed * Time.deltaTime;
    }
}
