using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowValueEngine : MonoBehaviour
{
    private Text percentageText;
    public int correct;
    public GameObject Gauge;
    public GameObject gaugeInteract;


    void Start()
    {
        percentageText = GetComponent<Text>();
    }


    public void textUpdate(float value)
    {
        int sliderVal = (int)value;
        percentageText.text = "Fuel Remaining:\n" + (sliderVal).ToString() + "%";
        if (sliderVal == correct)
        {
            Gauge.GetComponent<Slider>().enabled = false;
            GameControl.control.score += 10;
            if (this.tag == "Eng1")
            {
                gaugeInteract.GetComponent<OxyGaugeInteract>().isEng1Set();
            }
            else if (this.tag == "Eng2")
            {
                gaugeInteract.GetComponent<OxyGaugeInteract>().isEng2Set();
            }
        }
    }
}
