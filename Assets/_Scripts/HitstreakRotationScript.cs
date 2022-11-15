using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitstreakRotationScript : MonoBehaviour
{
    private Transform myTransform; // Instance variables (ivars)
    public float x, y, z;


    void Start()
    {
        myTransform = transform; // transform is actually a function call!!!!
    }

    void Update()
    {
        float dt = Time.deltaTime;
        myTransform.Rotate(x * dt, y * dt, z * dt);
    }
}
