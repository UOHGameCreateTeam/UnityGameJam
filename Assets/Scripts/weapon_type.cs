using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class weapon_type : MonoBehaviour
{
    // Start is called before the first frame update
    private int tmp = 0;
    private int weapon_num;
    public TextMeshProUGUI weapon;
    void Start()
    {
        string show_text;
;
        tmp = weapon_num;
        show_text = string.Format("{0}", tmp);
        weapon.text = show_text;

    }

}
