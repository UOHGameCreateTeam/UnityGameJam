using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class start_button : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject stage;
    stage_dummy script;

    void Start()
    {
        script = stage.GetComponent<stage_dummy>();
    }
    public void OnClisk()
    {
        int tmp = 0;
        string stage = "stage_";

        tmp = script.play_stage;

        if(tmp == 0)
        {
            stage = "tutorial";
        }
        else
        {
            stage += string.Format("{0}", 1);
        }

        GetComponent<battle_value_send>().enabled = true;

    }
}
