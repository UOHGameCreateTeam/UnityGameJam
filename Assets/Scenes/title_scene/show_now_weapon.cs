using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class show_now_weapon : MonoBehaviour
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
        //null���������Ă邩�玡��
        string show_text;

        dummy_cs dummy;
        GameObject obj = GameObject.Find("GameObject");
        dummy = obj.GetComponent<dummy_cs>();
        wp_count = dummy.now;

        show_text = string.Format("{0}", wp_count);
        //Debug.Log(wp_count);
        //null���������Ă邩�玡��
        

        now_weapon.text = show_text;

    }
}
