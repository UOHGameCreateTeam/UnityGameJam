using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class right_sc : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Text CountText;
    private int tmp = 0;
    public void OnClisk()
    {
        print("right");
        change();
        Debug.Log(tmp);
    }
    public void change()
    {
        //int tmp = 0;
        dummy_cs dummy;
        GameObject obj = GameObject.Find("GameObject");
        dummy = obj.GetComponent<dummy_cs>();
        tmp = dummy.now;
        if(tmp < 5)
        {
            dummy.now += 1;
        }

    }
}
