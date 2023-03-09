using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpeed : MonoBehaviour
{
    public MouseScrollHiddenObject mouseScrollHiddenObject;
    public MouseScrollCamera mouseScrollCamera;

    void Start()
    {
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        mouseScrollHiddenObject.speed = mouseScrollHiddenObject.speed / 2.5f * 0.5f;
        mouseScrollCamera.speed = mouseScrollCamera.speed / 2.5f * 0.5f;
    }

    private void OnTriggerExit(Collider other)
    {
        mouseScrollHiddenObject.speed = mouseScrollHiddenObject.speed * 2.5f / 0.5f;
        mouseScrollCamera.speed = mouseScrollCamera.speed * 2.5f / 0.5f;
        
        foreach (GameObject go in GameObject.FindGameObjectsWithTag("Selected"))
        {
            go.tag = "Selectable";
            Debug.Log("Exit trigger zone, selected object is deselected, tag changes to selectable");
        }
        
    }
}
