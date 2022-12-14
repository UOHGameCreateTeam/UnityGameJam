using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class energy_gage : MonoBehaviour
{
    public Slider slider;

    void Start()
    {
        slider.value = 0;
    }
     void Update()
    {
        if(slider.value <= 100)
        {
            slider.value += 0.01f;
        }
    }

}
