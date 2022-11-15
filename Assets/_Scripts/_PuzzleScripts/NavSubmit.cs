using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NavSubmit : MonoBehaviour
{
    public GameObject puzzleLocation;
    public GameObject navButton;
    public GameObject error;
    public GameObject destDropdown;
    public GameObject arrivalText;
    private Dropdown planetSelect;
    void Start()
    {
        planetSelect = destDropdown.GetComponent<Dropdown>();
    }

    void Update()
    {
        if (this.tag == "navInit")
        {
            changeShipArrival();
        }
        else if (this.tag == "navFinal")
        {
            changeEscArrival();
        }
    }

    void changeShipArrival()
    {
        if (planetSelect.value == 1)
        {
            arrivalText.GetComponent<Text>().text = "Arrival Time:\n 4 days";
            //line for image change
        }

        if (planetSelect.value == 2)
        {
            arrivalText.GetComponent<Text>().text = "Arrival Time:\n 3 days";
            //line for image change
        }

        if (planetSelect.value == 3)
        {
            arrivalText.GetComponent<Text>().text = "Arrival Time:\n 7 days";
            //line for image change
        }
        navButton.GetComponent<Button>().onClick.AddListener(checkShipSubmission);
    }
    void changeEscArrival()
    {
        if (planetSelect.value == 1)
        {
            arrivalText.GetComponent<Text>().text = "Arrival Time:\n 3 days";
        }

        if (planetSelect.value == 2)
        {
            arrivalText.GetComponent<Text>().text = "Arrival Time:\n 4 days";
        }

        navButton.GetComponent<Button>().onClick.AddListener(checkEscSubmission);
    }
    void checkShipSubmission()
    {
        if (planetSelect.value != 2)
        {
            error.SetActive(true);
        }
        else
        {
            GameControl.control.score += 20;
            puzzleLocation.GetComponent<DropdownInteract>().isNavSet();
        }
    }
    void checkEscSubmission()
    {
        if (planetSelect.value != 1)
        {
            error.SetActive(true);
        }
        else
        {
            GameControl.control.score += 20;
            puzzleLocation.GetComponent<DropdownInteract>().isEscSet();
        }
    }
}
