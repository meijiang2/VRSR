using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchButton : MonoBehaviour
{
    private Animation anim;
    public bool isOpenAnimPlayed = false;

    void Start()
    {
        anim = GameObject.Find("AppleWatch").GetComponent<Animation>();
    }

    void Update()
    {
        
    }

    public void OpenWatch()
    {
        //plays animation
        Debug.Log("open watch");
        anim.Play("animOpenWatch");
        isOpenAnimPlayed = true;
    }

    public void CloseWatch()
    {
        //plays animation
        Debug.Log("close watch \n anim close watch is played, isOpenAnimPlayed set to false");
        //anim.Play("animCloseWatch");
        isOpenAnimPlayed = false;
    }
}
