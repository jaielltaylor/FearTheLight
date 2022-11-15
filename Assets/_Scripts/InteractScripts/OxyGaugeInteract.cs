using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxyGaugeInteract : MonoBehaviour
{
    private bool gaugeSet = false;
    private bool eng1Set = false;
    private bool eng2Set = false;
    public GameObject Puzzle;

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
        if (Input.GetKeyDown(KeyCode.E) && (withinRange <= 3))
        {
            Puzzle.SetActive(true);
        }

        //Checking if Puzzle is Complete
        if (gaugeSet)
        {
            Puzzle.SetActive(false);
            this.GetComponent<PanelPopup>().isComplete();
            GameObject.Find("ObjectiveText").GetComponent<Text>().text = "Current Objective: Re-enable Navigation.";
        }
       
        if (eng1Set)
        {
            Puzzle.SetActive(false);
            this.GetComponent<PanelPopup>().isComplete();
            GameControl.control.GetComponent<GameControl>().enableEscape();
            GameObject.Find("ObjectiveText").GetComponent<Text>().text = "Current Objective: Escape.";
        }
        
        if (eng2Set)
        {
            Puzzle.SetActive(false);
            this.GetComponent<PanelPopup>().isComplete();
        }
    }

    public void isGaugeSet()
    {
        gaugeSet = true;
    }
    public void isEng1Set()
    {
        eng1Set = true;
    }
    public void isEng2Set()
    {
        eng2Set = true;
    }
}
