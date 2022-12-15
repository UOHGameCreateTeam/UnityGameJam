using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hp_gage : MonoBehaviour
{
    public Slider slider;
    public GameObject Player;
    player_status script;
    void Start()
    {
        Player = GameObject.Find("Player"); //Playerをオブジェクトの名前から取得して変数に格納する
        script = Player.GetComponent<player_status>();
        slider.value = script.hp;
    }
     void Update()
    {
        slider.value = script.hp;

    }

}
