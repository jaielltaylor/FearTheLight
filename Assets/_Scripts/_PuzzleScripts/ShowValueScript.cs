using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ShowValueScript : MonoBehaviour
{
    private Text percentageText;
    public double correct;
    public GameObject Gauge;
    public GameObject gaugeInteract;


    void Start()
    {
        percentageText = GetComponent<Text>();
    }


    public void textUpdate(float value)
    {
        double sliderVal = System.Math.Round(100 / value, 2);
        percentageText.text = (sliderVal).ToString() + " bar";
        if (sliderVal == correct)
        {
            Gauge.GetComponent<Slider>().enabled = false;
            GameControl.control.score += 10;
            gaugeInteract.GetComponent<OxyGaugeInteract>().isGaugeSet();
        }
    }
}
