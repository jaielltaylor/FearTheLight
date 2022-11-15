using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightPower: MonoBehaviour
{
    public Light flashlight1;
    public Light flashlight2;
    public Light flashlight3;
    public Collider lightCollider;
    // Update is called once per frame
    void Start()
    {
        lightCollider = GetComponent<Collider>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) && flashlight1.enabled == false && flashlight2.enabled == false && flashlight3.enabled == false)
        {
            flashlight1.enabled = true;
            flashlight2.enabled = true;
            flashlight3.enabled = true;
            lightCollider.enabled = true;
        } else if (Input.GetKeyDown(KeyCode.Mouse0) && flashlight1.enabled == true && flashlight2.enabled == true && flashlight3.enabled == true)
        {
            flashlight1.enabled = false;
            flashlight2.enabled = false;
            flashlight3.enabled = false;
            lightCollider.enabled = false;
        }
    }
}
