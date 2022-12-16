using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy_status : MonoBehaviour, EDmage
{
    public int hp = 500;
    public GameObject player_score;
    public GameObject gameobject;
    private float time = 0f;
    public float limit_time = 3f;
    GameResult_judge judge_script;
    score_board script;

    void Start()
    {
        this.GetComponent<enemy_bullet>().enabled = true;
        this.GetComponent<enemy_bullet2>().enabled = true;
        //this.GetComponent<enemy_bullet_behaib>().enabled = true;
        this.GetComponent<enemy_move>().enabled = true;
        //Playerをオブジェクトの名前から取得して変数に格納する
        script = player_score.GetComponent<score_board>();
        judge_script = gameobject.GetComponent<GameResult_judge>();
    }
    public void AddDamage(int damage)
    {
        hp -= damage;
        

        if (hp <= 0)
        {

            this.GetComponent<enemy_move>().enabled = false;
            
            judge_script.judgement = true;
            
        }
    }
    public void AddScore(int damage)
    {
        script.score += damage * 10;
    }

    void Update()
    {
        // 敵が死んでからの猶予フレーム
        if (hp <= 0)
        {
            Debug.Log("sssss");
            if (time >= limit_time)
            {
                this.gameObject.SetActive(false);
                GetComponent<result_value_send>().enabled = true;
            }
            time += Time.deltaTime;
        }
       
    }
}