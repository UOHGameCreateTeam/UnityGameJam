using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class stage_select : MonoBehaviour
{
    // Start is called before the first frame update
    private int tmp = 0;

    public TextMeshProUGUI now_weapon;

    void Start()
    {
        now_weapon = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        int wp_count = 0;
        //nullが代入されてるから治す
        string show_text;

        dummy_obj dummy;
        GameObject obj = GameObject.Find("GameObject");
        dummy = obj.GetComponent<dummy_obj>();
        wp_count = dummy.now;

        show_text = string.Format("{0}", wp_count);
        //Debug.Log(wp_count);
        //nullが代入されてるから治す
        
        if(wp_count == 0)
        {
            show_text = "チュートリアル";
        }

        now_weapon.text = show_text;

    }
}
