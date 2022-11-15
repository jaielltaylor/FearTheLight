using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownInteract : MonoBehaviour
{
    private bool navSet = false;
    private bool escSet = false;
    private bool dataSet = false;
    private bool powerSet = false;

    public GameObject Puzzle;
    public GameObject secondPuzzle;

    private bool isEscape = false;
    public GameObject Player;
    private Transform panelTransform;
    void Start()
    {
        panelTransform = transform;
    }

    void Update()
    {
        //Starting Puzzle
        float withinRange = Vector3.Distance(panelTransform.position, Player.transform.position);
        if (Input.GetKeyDown(KeyCode.E) && (withinRange <= 5))
        {
            if (isEscape == true) { secondPuzzle.SetActive(true); }
            else { Puzzle.SetActive(true); }
        }

        //Checking if Puzzle is Complete
        if (navSet) //Navigation
        {
            Puzzle.SetActive(false);
            isEscape = true;
            GameObject.Find("ObjectiveText").GetComponent<Text>().text = "Current Objective: Situation Critical. Check Center Console.";
        }

        if (escSet) // Escape Pod Navigation
        {
            secondPuzzle.SetActive(false);
            this.GetComponent<PanelPopup>().isComplete();
            GameObject.Find("ObjectiveText").GetComponent<Text>().text = "Current Objective: Upload Data From Lab.";
        }

        if (powerSet) // Electrical
        {
            Puzzle.SetActive(false);
            this.GetComponent<PanelPopup>().isComplete();
            GameObject.Find("ObjectiveText").GetComponent<Text>().text = "Current Objective: Fuel Engines.";
        }

        if (dataSet) // Lab
        {
            Puzzle.SetActive(false);
            this.GetComponent<PanelPopup>().isComplete();
            GameObject.Find("ObjectiveText").GetComponent<Text>().text = "Current Objective: Head Down to Lower Deck.";
        }
    }

    public void isNavSet()
    {
        navSet = true;
    }

    public void isEscSet()
    {
        escSet = true;
    }
    public void isPowerSet()
    {
        powerSet = true;
    }

    public void isDataSet()
    {
        dataSet = true;
    }
}
