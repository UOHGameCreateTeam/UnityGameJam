using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hp_gage : MonoBehaviour
{
    public Slider slider;

    void Start()
    {
        slider.value = 100;
    }
     void Update()
    {
        float tmp;
        tmp = timer_control.Get_Timer();
        if (tmp >= 0)
        {

            if (slider.value > 0)
            {
                slider.value -= 0.01f;
            }
        }

    }

}
