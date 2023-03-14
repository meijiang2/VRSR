using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchRotation : MonoBehaviour
{
    private Vector3 watchRotation;
    private float speed = 2f;

    void Start()
    {
        watchRotation.y = 10;
    }

    void Update()
    {
        transform.Rotate(watchRotation * speed * Time.deltaTime);
    }
}
