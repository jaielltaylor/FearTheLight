using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorControl : MonoBehaviour
{
    public GameObject Player;
    public GameObject Door;
    private AudioSource audio;
    private Transform controlTransform;
    private Animator doorAnimator;
    private float withinRange;
    
    void Start()
    {
        controlTransform = transform;
        doorAnimator = Door.GetComponent<Animator>();
        audio = Door.GetComponent<AudioSource>();
        doorAnimator.enabled = true;
    }
    void Update()
    {
        float withinRange = Vector3.Distance(controlTransform.position, Player.transform.position);
        
        if (Door.transform.tag.Equals("door1"))
        {
            if (Input.GetKeyDown(KeyCode.E) && withinRange <= 2)
            {
                doorAnimator.SetBool("isOneOpen", true);
                audio.Play();

                bool changeObjective = true;
                if (changeObjective)
                {
                    GameObject.Find("ObjectiveText").GetComponent<Text>().text = "Current Objective: Find a flashlight.";
                }
                changeObjective = false;
            }
            else if (Input.GetKeyDown(KeyCode.Q) && withinRange <= 2)
            {
                doorAnimator.SetBool("isOneOpen", false);
            }
        }

        if (Door.transform.tag.Equals("door2"))
        {
            if (Input.GetKeyDown(KeyCode.E) && withinRange <= 2)
            {
                doorAnimator.SetBool("isTwoOpen", true);
                audio.Play();
            }
            else if (Input.GetKeyDown(KeyCode.Q) && withinRange <= 2)
            {
                doorAnimator.SetBool("isTwoOpen", false);
            }
        }

        if (Door.transform.tag.Equals("door3"))
        {
            if (Input.GetKeyDown(KeyCode.E) && withinRange <= 2)
            {
                doorAnimator.SetBool("isThreeOpen", true);
                audio.Play();
            }
            else if (Input.GetKeyDown(KeyCode.Q) && withinRange <= 2)
            {
                doorAnimator.SetBool("isThreeOpen", false);
            }
        }

        if (Door.transform.tag.Equals("door4"))
        {
            if (Input.GetKeyDown(KeyCode.E) && withinRange <= 2)
            {
                doorAnimator.SetBool("isFourOpen", true);
                audio.Play();
            }
            else if (Input.GetKeyDown(KeyCode.Q) && withinRange <= 2)
            {
                doorAnimator.SetBool("isFourOpen", false);
            }
        }

        if (Door.transform.tag.Equals("door5"))
        {
            if (Input.GetKeyDown(KeyCode.E) && withinRange <= 2)
            {
                doorAnimator.SetBool("isFiveOpen", true);
                audio.Play();
            }
            else if (Input.GetKeyDown(KeyCode.Q) && withinRange <= 2)
            {
                doorAnimator.SetBool("isFiveOpen", false);
            }
        }

        if (Door.transform.tag.Equals("door6"))
        {
            if (Input.GetKeyDown(KeyCode.E) && withinRange <= 2)
            {
                doorAnimator.SetBool("isSixOpen", true);
                audio.Play();
            }
            else if (Input.GetKeyDown(KeyCode.Q) && withinRange <= 2)
            {
                doorAnimator.SetBool("isSixOpen", false);
            }
        }

        if (Door.transform.tag.Equals("door7"))
        {
            if (Input.GetKeyDown(KeyCode.E) && withinRange <= 2)
            {
                doorAnimator.SetBool("isSevenOpen", true);
                audio.Play();
            }
            else if (Input.GetKeyDown(KeyCode.Q) && withinRange <= 2)
            {
                doorAnimator.SetBool("isSevenOpen", false);
            }
        }

        if (Door.transform.tag.Equals("door8"))
        {
            if (Input.GetKeyDown(KeyCode.E) && withinRange <= 2)
            {
                doorAnimator.SetBool("isEightOpen", true);
                audio.Play();
            }
            else if (Input.GetKeyDown(KeyCode.Q) && withinRange <= 2)
            {
                doorAnimator.SetBool("isEightOpen", false);
            }
        }
        
        if (Door.transform.tag.Equals("door9"))
        {
            if (Input.GetKeyDown(KeyCode.E) && withinRange <= 2)
            {
                doorAnimator.SetBool("isNineOpen", true);
                audio.Play();
            }
            else if (Input.GetKeyDown(KeyCode.Q) && withinRange <= 2)
            {
                doorAnimator.SetBool("isNineOpen", false);
            }
        }

        if (Door.transform.tag.Equals("door10"))
        {
            if (Input.GetKeyDown(KeyCode.E) && withinRange <= 2)
            {
                doorAnimator.SetBool("isTenOpen", true);
                audio.Play();
            }
            else if (Input.GetKeyDown(KeyCode.Q) && withinRange <= 2)
            {
                doorAnimator.SetBool("isTenOpen", false);
            }
        }

        if (Door.transform.tag.Equals("door11"))
        {
            if (Input.GetKeyDown(KeyCode.E) && withinRange <= 2)
            {
                doorAnimator.SetBool("isElevenOpen", true);
                audio.Play();
            }
            else if (Input.GetKeyDown(KeyCode.Q) && withinRange <= 2)
            {
                doorAnimator.SetBool("isElevenOpen", false);
            }
        }

        if (Door.transform.tag.Equals("door12"))
        {
            if (Input.GetKeyDown(KeyCode.E) && withinRange <= 2)
            {
                doorAnimator.SetBool("isTwelveOpen", true);
                audio.Play();
            }
            else if (Input.GetKeyDown(KeyCode.Q) && withinRange <= 2)
            {
                doorAnimator.SetBool("isTwelveOpen", false);
            }
        }
    }
}
