using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class energy_text : MonoBehaviour
{
    public GameObject Player;
    player_status script;
    public TMP_Text energyText;
    private string name_player = "Player";
    private string name_hptext = "hpText";
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player"); //Playerをオブジェクトの名前から取得して変数に格納する
        script = Player.GetComponent<player_status>();
    }

    // Update is called once per frame
    void Update()
    {
        if (script == null) // <- NULLチェックを行う。
        {
            
            return; // <- この関数を終了します。
        }
        if (energyText == null)
        {
            
            return; // <- この関数を終了します。
        }
        energyText.text = script.energy.ToString();

    }
}
