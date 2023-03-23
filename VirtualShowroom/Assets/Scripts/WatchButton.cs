using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchButton : MonoBehaviour
{
    public Animation anim;
    public bool isOpenAnimPlayed = false;

    void Start()
    {
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
        anim.Play("CINEMA_4D_Main");
        isOpenAnimPlayed = false;
    }
}
