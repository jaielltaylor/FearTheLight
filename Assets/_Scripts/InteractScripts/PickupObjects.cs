using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupObjects : MonoBehaviour
{
    private Transform myTransform;
    public GameObject myFlashlight;

    void Start()
    {
        myTransform = transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag.Equals("Tool"))
        {
            Destroy(other.gameObject);
            myFlashlight.SetActive(true);
            GameObject.Find("ObjectiveText").GetComponent<Text>().text = "Current Objective: Restore Oxygen";
        }
        else if (other.transform.tag.Equals("Cell"))
        {
            other.transform.parent = myTransform;
        }
        else if (other.transform.tag.Equals("Tank"))
        {
            other.transform.parent = myTransform;
        }
    }
}
