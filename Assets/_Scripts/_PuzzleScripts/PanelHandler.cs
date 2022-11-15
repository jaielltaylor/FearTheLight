using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelHandler : MonoBehaviour
{
    private int numCorrect;
    private int curCorrect;
    public GameObject Puzzle;

    public GameObject Player;
    private Transform panelTransform;
    void Start()
    {
        panelTransform = transform;
        curCorrect = 0;
        numCorrect = 4;
    }

    void Update()
    {
        //Starting Puzzle
        float withinRange = Vector3.Distance(panelTransform.position, Player.transform.position);
        if (Input.GetKeyDown(KeyCode.E) && (withinRange <= 2))
        {
            Puzzle.SetActive(true);
        }

        //Checking if Puzzle is Complete
        if (curCorrect == numCorrect)
        {
            Puzzle.SetActive(false);
            this.GetComponent<PanelPopup>().isComplete();
            lifeHasManyDoors();
        }
    }

    public void addCorrect()
    {
        curCorrect++;
    }

    void lifeHasManyDoors()
    {
        //Enabling Door
        if (Puzzle.tag.Equals("Chamber"))
        {
            GameControl.control.GetComponent<GameControl>().enableChamberDoor();
        }
    }
}
