using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDragHandler : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public GameObject curPosition;
    public GameObject puzzleHandler;
    private Transform wireTransform;
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        if ((Vector3.Distance(this.transform.localPosition, curPosition.transform.localPosition) <= 10f) && (puzzleHandler.tag.Equals("Chamber")))
        {
            wireTransform.position = curPosition.transform.position;
            GameControl.control.score += 5;
            this.enabled = false;
            puzzleHandler.GetComponent<PanelHandler>().addCorrect();
        }
        else if ((Vector3.Distance(this.transform.localPosition, curPosition.transform.localPosition) <= 20f) && (puzzleHandler.tag.Equals("cafeRight")))
        {
            wireTransform.position = curPosition.transform.position;
            GameControl.control.score += 5;
            this.enabled = false;
            puzzleHandler.GetComponent<CafeRightPanelHandler>().addCorrect();
        }
        else if ((Vector3.Distance(this.transform.localPosition, curPosition.transform.localPosition) <= 20f) && (puzzleHandler.tag.Equals("cafeLeft")))
        {
            wireTransform.position = curPosition.transform.position;
            GameControl.control.score += 5;
            this.enabled = false;
            puzzleHandler.GetComponent<CafeLeftPanelHandler>().addCorrect();
        }
        else if ((Vector3.Distance(this.transform.localPosition, curPosition.transform.localPosition) <= 20f) && (puzzleHandler.tag.Equals("Stairway")))
        {
            wireTransform.position = curPosition.transform.position;
            GameControl.control.score += 5;
            this.enabled = false;
            puzzleHandler.GetComponent<StairwayPanelHandler>().addCorrect();
        }
        else
        {
            this.transform.position.Set(0f,0f,0f);
        }
    }
    void Start()
    {
        wireTransform = transform;
    }
}
