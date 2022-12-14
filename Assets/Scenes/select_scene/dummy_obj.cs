using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dummy_obj : MonoBehaviour
{
    public int now = 0;
    // Start is called before the first frame update
    void Start()
    {
        print("dummy_on");
    }

    // Update is called once per frame
    void Update()
    {
        if(now < 0)
        {
            now = 0;
        }
        else if(now >= 6)
        {
            now = 6;
        }
    }
}
