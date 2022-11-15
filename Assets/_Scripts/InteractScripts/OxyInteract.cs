using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxyInteract : MonoBehaviour
{
    public GameObject Player;
    public GameObject Tank;
    public GameObject placedTank;
    private Transform destTransform;
    private float withinRange;

    void Start()
    {
        destTransform = transform; 
    }

    void Update()
    {
        float withinRange = Vector3.Distance(destTransform.position, Player.transform.position);
        if (destTransform.tag.Equals("oxy"))
        {
            if (Tank != null)
            {
                if (Input.GetKeyDown(KeyCode.E) && (Tank.transform.parent == Player.transform))
                {
                    Destroy(Tank);
                    placedTank.SetActive(true);
                    this.GetComponent<OxyPopup>().placedTank();
                    GameControl.control.score += 10;
                }
            }
        }
    }
}
