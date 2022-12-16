using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy_status : MonoBehaviour, EDmage
{
    public int hp = 500;
    public GameObject player_score;
    public GameObject gameobject;
    GameResult_judge judge_script;
    score_board script;

    void Start()
    {
         //Playerをオブジェクトの名前から取得して変数に格納する
        script = player_score.GetComponent<score_board>();
        judge_script = gameobject.GetComponent<GameResult_judge>();
    }
    public void AddDamage(int damage)
    {
        hp -= damage;
        

        if (hp <= 0)
        {
            this.gameObject.SetActive(false);
            judge_script.judgement = true;
            GetComponent<result_value_send>().enabled = true;
            var a = new result_value_send();
        }
    }
    public void AddScore(int damage)
    {
        script.score += damage * 10;
    }
}
