using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class weapon_type : MonoBehaviour
{
    // Start is called before the first frame update
    private int tmp = 0;

    public TextMeshProUGUI weapon;
    void Start()
    {
        string show_text;

        weapon_dummy dum_1 = new weapon_dummy();
        tmp = dum_1.GetSetProperty;
        Debug.Log(tmp);

        show_text = string.Format("{0}", tmp);
        weapon.text = show_text;

    }

    void Update()
    {
        string show_text;

        weapon_dummy dum_1 = new weapon_dummy();
        tmp = dum_1.GetSetProperty;
        Debug.Log(tmp);

        show_text = string.Format("{0}", tmp);
        weapon.text = show_text;
    }
}
