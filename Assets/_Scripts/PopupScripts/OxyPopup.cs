using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxyPopup : MonoBehaviour
{
    private GameObject popup;
    private bool tankAdded = false;
    private bool hasCollided = false;
    private string labelText = "";

    void heyListen()
    {
        popup = GameObject.Find("PopupText");
        popup.SetActive(true);
        popup.GetComponent<Text>().text = labelText;
    }

    private void OnTriggerEnter(Collider other)
    {
        //Somehow rely on Oxygen Tank's tag
        if ((other.tag == "Tank") && (tankAdded == false))
        {
            hasCollided = true;
            labelText = "Hit E to insert the Oxygen Tank";
            heyListen();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag.Equals("Player") && (tankAdded))
        {
            hasCollided = false;
            popup.GetComponent<Text>().text = "";
        }
    }
    public void placedTank()
    {
        tankAdded = true;
    }
}
