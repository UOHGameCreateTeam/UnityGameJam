using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class result_value_send : MonoBehaviour
{
    public GameObject gameobject;
    public GameObject Score;
    GameResult_judge script_judge;
    score_board scipt_score;
    private void Start()
    {
        script_judge = gameobject.GetComponent<GameResult_judge>();
        scipt_score = Score.GetComponent<score_board>();
        // イベントに登録
        SceneManager.sceneLoaded += GameSceneScoreLoaded;

        // シーン切り替え
        SceneManager.LoadScene("result");
    }
    private void GameSceneScoreLoaded(Scene next, LoadSceneMode mode)
    {
        // シーン切り替え後のスクリプトを取得
        var gameManager = GameObject.FindWithTag("GameManager").GetComponent<battle_judge>();
        var gameManager1 = GameObject.FindWithTag("GameManager").GetComponent<result_score>();

        // データを渡す処理
        gameManager.game_result = script_judge.judgement;
        gameManager1.score = scipt_score.score;

        // イベントから削除
        SceneManager.sceneLoaded -= GameSceneScoreLoaded;

    }
}
