using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public static GameControl control;
    
    public int health;
    public int score;
    private bool escape = false;

    void Awake()
    {
        if (control == null)        // If this is the first scene...
        {
            DontDestroyOnLoad(gameObject);
            control = this;
        }
        else if (control != this)   // For any subsequent scene that uses GameControl...
        {       // If I am the new instance of the GameControl script...
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        GameObject healthPoints = GameObject.Find("HealthText");
        healthPoints.GetComponent<Text>().text = "Health: " + health.ToString();

        GameObject scorePoints = GameObject.Find("ScoreText");
        scorePoints.GetComponent<Text>().text = "Score: " + score.ToString();

        if (escape)
        {
            //For escape pods near end of game
            GameObject.Find("EscapePodsConsole").GetComponent<DoorControl>().enabled = true;
            GameObject.Find("EscapePodsConsole1").GetComponent<DoorControl>().enabled = true;
            enabled = false;
        }
    }

    public void enableChamberDoor()
    {
        GameObject.Find("chamberConsole").GetComponent<DoorControl>().enabled = true;
    }

    public void enableStairwayDoor()
    {
        GameObject.Find("StairwayConsole").GetComponent<DoorControl>().enabled = true;
    }
    public void enableCafeRight()
    {
        GameObject.Find("CafeConsoleRight").GetComponent<DoorControl>().enabled = true;
    }
    public void enableCafeLeft()
    {
        GameObject.Find("CafeConsoleLeft").GetComponent<DoorControl>().enabled = true;
    }
    public void enableEscape()
    {
        escape = true;
    }
}
