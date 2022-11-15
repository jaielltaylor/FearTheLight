using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConsolePopup : MonoBehaviour
{
    private GameObject popup;
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
        if (other.tag == "Player")
        {
            hasCollided = true;
            labelText = "Hit E to open the door\nHit Q to Lock the Door";
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
}
