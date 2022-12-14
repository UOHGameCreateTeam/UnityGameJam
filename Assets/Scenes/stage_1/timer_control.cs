using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer_control : MonoBehaviour
{
    // Start is called before the first frame update
    public static float current_time;
    void Start()
    {
        current_time = -3f;
    }

    // Update is called once per frame
    void Update()
    {
        float delta_time;

        delta_time = Time.deltaTime;
        current_time += delta_time;

    }
    public float GetSetProperty
    {
        get { return current_time; }
        set { current_time = value; }
    }
}
