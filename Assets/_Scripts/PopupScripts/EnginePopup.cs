using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnginePopup : MonoBehaviour
{
    private GameObject popup;
    private bool cellAdded = false;
    private bool hasCollided = false;
    private string labelText = "";

    private void Start()
    {
        popup = GameObject.Find("PopupText");
    }
    void heyListen()
    {
        popup.SetActive(true);
        popup.GetComponent<Text>().text = labelText;
    }

    private void OnTriggerEnter(Collider other)
    {
        //Somehow rely on Oxygen Tank's tag
        if ((other.tag == "Cell") && (cellAdded == false))
        {
            hasCollided = true;
            labelText = "Hit E to insert the Fuel Cell";
            heyListen();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag.Equals("Player") && (cellAdded))
        {
            hasCollided = false;
            popup.GetComponent<Text>().text = "";
        }
    }
    public void placedCell()
    {
        cellAdded = true;
    }
}
