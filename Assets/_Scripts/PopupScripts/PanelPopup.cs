using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelPopup : MonoBehaviour
{
    private GameObject popup;
    private bool finished = false;
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
        if (other.tag.Equals("Player") && (finished == false))
        {
            hasCollided = true;
            labelText = "Hit E to start task.";
            heyListen();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            hasCollided = false;
            popup.GetComponent<Text>().text = "";
        }
    }

    public void isComplete()
    {
        finished = true;
    }
}
