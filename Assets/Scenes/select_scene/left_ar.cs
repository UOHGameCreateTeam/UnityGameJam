using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class left_ar : MonoBehaviour
{
    // Start is called before the first frame update
    private int tmp = 0;
    public GameObject stage;
    stage_dummy script;

    void Start()
    {
        script = stage.GetComponent<stage_dummy>();
    }
    public void OnClisk()
    {
        print("left");
        change();
        Debug.Log(tmp);
    }
    public void change()
    {
        //int tmp = 0;

 
        tmp = script.play_stage;
        if(tmp >= 0)
        {
            script.play_stage -= 1;
        }

        
    }
}
