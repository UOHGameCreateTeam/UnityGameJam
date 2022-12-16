using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class weapon_selet : MonoBehaviour
{

    public TextMeshProUGUI now_weapon;
    public GameObject weapon_dum;
    weapon_dummy script;

    void Start()
    {
        now_weapon = GetComponent<TextMeshProUGUI>();
        script = weapon_dum.GetComponent<weapon_dummy>();
    }

    void Update()
    {
        int wp_count = 0;
        string show_text;

        wp_count = script.use_weapon;
        if(wp_count < 0)
        {
            wp_count = 0;
        }

        show_text = string.Format("{0}", wp_count);
 

        now_weapon.text = show_text;

    }
}
