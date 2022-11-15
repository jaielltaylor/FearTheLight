using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwap : MonoBehaviour
{
    private int currentscene = 2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && currentscene == 2)
        {
            SceneManager.LoadScene(3);
            currentscene = 3;
            GameObject.Find("ObjectiveText").GetComponent<Text>().text = "Current Objective: Divert Power to Shields";
        }
        else if (other.tag == "Player" && currentscene == 3)
        {
            SceneManager.LoadScene(2);
            currentscene = 2;
        }
    }
}
