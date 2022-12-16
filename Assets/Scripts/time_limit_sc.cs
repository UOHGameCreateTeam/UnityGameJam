using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class time_limit_sc : MonoBehaviour
{
    public TextMeshProUGUI time_left;
    private static float  time_limit;
    // Start is called before the first frame update
    void Start()
    {
        time_limit = 100;
        float tmp = time_limit;
        string show_text;

         show_text = string.Format("{0}", tmp);
         time_left.text = show_text;
        
    }

    // Update is called once per frame
    void Update()
    {
        float tmp = timer_control.Get_Timer();
        string show_text;

        tmp = time_limit - tmp;

        show_text = string.Format("{0:f2}", tmp);
        time_left.text = show_text;

        if (tmp <= 0)
        {
            SceneManager.LoadScene("result");
        }
    }
}
