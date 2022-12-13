using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class hpmanager : MonoBehaviour
{
    public GameObject Player;
    player_hp script;
    public TMP_Text hpText;
    private string name_player = "Player";
    private string name_hptext = "hpText";
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player"); //Playerをオブジェクトの名前から取得して変数に格納する
        script = Player.GetComponent<player_hp>();
    }

    // Update is called once per frame
    void Update()
    {
        if (script == null) // <- NULLチェックを行う。
        {
            Debug.Log($"{name_player} has null player"); // <- ゲームオブジェクトの名前を記録する。
            return; // <- この関数を終了します。
        }
        if (hpText == null)
        {
            Debug.Log($"{name_hptext} has null ui"); // <- ゲームオブジェクトの名前を記録する。
            return; // <- この関数を終了します。
        }
        hpText.text = script.hp.ToString();

    }
}
