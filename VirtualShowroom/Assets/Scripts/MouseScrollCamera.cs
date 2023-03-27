using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class MouseScrollCamera : MonoBehaviour
{
    public CinemachineVirtualCamera vc;
    private CinemachineTrackedDolly dt;
    public float speed;

    void Awake()
    {
        vc = gameObject.GetComponent<CinemachineVirtualCamera>();
        dt = gameObject.GetComponent<CinemachineVirtualCamera>().GetCinemachineComponent<CinemachineTrackedDolly>();
        speed = 0.25f; //0.35
    }

    void Update()
    {
        if (vc.Priority == 10)
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
}