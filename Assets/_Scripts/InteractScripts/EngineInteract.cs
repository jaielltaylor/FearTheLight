using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineInteract : MonoBehaviour
{
    public GameObject Player;
    public GameObject Cell;
    public GameObject placedCell;
    private Transform destTransform;
    private float withinRange;

    void Start()
    {
        destTransform = transform;
    }

    void Update()
    {
        float withinRange = Vector3.Distance(destTransform.position, Player.transform.position);
        if (destTransform.tag.Equals("Eng1") || destTransform.tag.Equals("Eng2"))
        {
            if (Cell != null)
            {
                if (Input.GetKeyDown(KeyCode.E) && (Cell.transform.parent == Player.transform) && withinRange <= 3)
                {
                    Destroy(Cell);
                    placedCell.SetActive(true);
                    this.GetComponent<EnginePopup>().placedCell();
                    GameControl.control.score += 10;
                }
            }
        }
    }
}
