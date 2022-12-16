using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class battle_value_send : MonoBehaviour
{
    public GameObject weapon;
    public GameObject stage;
    weapon_dummy script_weapon;
    stage_dummy script_stage;
    private void Start()
    {
        script_weapon = weapon.GetComponent<weapon_dummy>();
        script_stage = stage.GetComponent<stage_dummy>();
        // イベントに登録
        SceneManager.sceneLoaded += GameSceneScoreLoaded;

        if (script_stage.play_stage == 1)
        {
            SceneManager.LoadScene("stage_1");
        }
        else 
        {
            SceneManager.LoadScene("stage_2");
        }
        
        
    }
    private void GameSceneScoreLoaded(Scene next, LoadSceneMode mode)
    {
        // シーン切り替え後のスクリプトを取得
        var gameManager = GameObject.FindWithTag("player_weapon").GetComponent<Pllayer_shoot>();
        var gameManager1 = GameObject.FindWithTag("player_weapon").GetComponent<weapon_type>();

        // データを渡す処理
        gameManager.select_weapon_number = script_weapon.use_weapon;

        // イベントから削除
        SceneManager.sceneLoaded -= GameSceneScoreLoaded;

    }
}
