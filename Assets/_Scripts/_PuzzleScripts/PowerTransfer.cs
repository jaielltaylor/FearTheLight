using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerTransfer : MonoBehaviour
{
    public GameObject puzzleLocation;
    public GameObject navButton;
    public GameObject error;
    public GameObject destDropdown;
    public GameObject percentageText;
    private Dropdown powerSelect;
    void Start()
    {
        powerSelect = destDropdown.GetComponent<Dropdown>();
    }

    void Update()
    {

    }
    void changePowerSelection()
    {
        if (powerSelect.value == 1)
        {
            percentageText.GetComponent<Text>().text = "100%";
        }

        if (powerSelect.value == 2)
        {
            percentageText.GetComponent<Text>().text = "100%";
        }

        if (powerSelect.value == 3)
        {
            percentageText.GetComponent<Text>().text = "20%";
        }

        if (powerSelect.value == 4)
        {
            percentageText.GetComponent<Text>().text = "100%";
        }
        navButton.GetComponent<Button>().onClick.AddListener(checkElecSubmission);
    }
    void changeDataSelection()
    {
        if (powerSelect.value == 1 || powerSelect.value == 2 || powerSelect.value == 4)
        {
            percentageText.GetComponent<Text>().text = "Data Uploaded.";
        }
        if (powerSelect.value == 3)
        {
            percentageText.GetComponent<Text>().text = "Data Not Uploaded.";
        }
        navButton.GetComponent<Button>().onClick.AddListener(checkDataSubmission);
    }

    public void checkElecSubmission()
    {
        if (powerSelect.value != 3)
        {
            error.SetActive(true);
        }
        else
        {
            GameControl.control.score += 20;
            puzzleLocation.GetComponent<DropdownInteract>().isPowerSet();
        }
    }
    public void checkDataSubmission()
    {
        if (powerSelect.value != 3)
        {
            error.SetActive(true);
        }
        else
        {
            GameControl.control.score += 20;
            puzzleLocation.GetComponent<DropdownInteract>().isDataSet();
        }
    }
}
