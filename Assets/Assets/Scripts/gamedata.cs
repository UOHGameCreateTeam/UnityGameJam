using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamedata : MonoBehaviour
{
    public static float score_result;
    public static bool battle_result;
    // Start is called before the first frame update
    void Start()
    {
        score_result = 0;
        battle_result = false;
    }

}
