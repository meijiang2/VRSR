using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action3Watch : MonoBehaviour
{
    private Animation anim;
    void Start()
    {
        anim = GameObject.Find("appleWatch").GetComponent<Animation>();
    }

    void Update()
    {
        
    }

    public void OpenWatch()
    {
        //plays animation
        Debug.Log("open watch");
        anim.Play("animOpenWatch");
    }
}
