using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitstreakTranslateScript : MonoBehaviour
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
        myTransform.Translate(x * dt, y * dt, z * dt);
    }
}
