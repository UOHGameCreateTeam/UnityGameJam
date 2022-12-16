using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wp_left : MonoBehaviour
{
    private int tmp = 0;
    public GameObject weapon_dum;
    weapon_dummy script;

    void Start()
    {
        script = weapon_dum.GetComponent<weapon_dummy>();
    }
    // Start is called before the first frame update
    public void OnClick()
    {
        print("left");
        change();
        Debug.Log(tmp);
    }
    public void change()
    {
        //int tmp = 0;


        tmp = script.use_weapon;
        if (tmp >= 0)
        {
            script.use_weapon -= 1;
        }


    }
}
