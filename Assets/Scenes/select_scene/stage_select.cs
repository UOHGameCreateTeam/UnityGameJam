using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class stage_select : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI now_stage;
    public GameObject stage;
    stage_dummy script;

    void Start()
    {
        now_stage = GetComponent<TextMeshProUGUI>();
        script = stage.GetComponent<stage_dummy>();
    }

    void Update()
    {
        int wp_count = 0;
        string show_text;

        wp_count = script.play_stage;

        show_text = string.Format("{0}", wp_count);
        //Debug.Log(wp_count);
        //null���������Ă邩�玡��
        
        if(wp_count == 0)
        {
            show_text = "Tutorial";
        }

        now_stage.text = show_text;

    }
}
