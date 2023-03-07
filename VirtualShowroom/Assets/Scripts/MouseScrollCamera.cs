using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class MouseScrollCamera : MonoBehaviour
{
    private CinemachineTrackedDolly dt;
    public float speed;
    void Start()
    {
        dt = gameObject.GetComponent<CinemachineVirtualCamera>().GetCinemachineComponent<CinemachineTrackedDolly>();
        speed = 0.25f; //0.35
    }

    void Update()
    {

        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            dt.m_PathPosition -= speed;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            dt.m_PathPosition += speed;
        }
    }
}