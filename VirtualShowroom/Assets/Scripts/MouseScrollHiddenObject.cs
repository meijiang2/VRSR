using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class MouseScrollHiddenObject : MonoBehaviour
{
    private CinemachineTrackedDolly ho;
    public float speed;

    void Awake()
    {
        ho = gameObject.GetComponent<CinemachineVirtualCamera>().GetCinemachineComponent<CinemachineTrackedDolly>();
        speed = 0.166f; //0.2325
    }

    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            ho.m_PathPosition -= speed;
            //Debug.Log("moving...back HO");
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            ho.m_PathPosition += speed;
            //Debug.Log("moving...forward HO");
        }
    }
}
