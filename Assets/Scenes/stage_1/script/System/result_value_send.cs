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
        // �C�x���g�ɓo�^
        SceneManager.sceneLoaded += GameSceneScoreLoaded;

        // �V�[���؂�ւ�
        SceneManager.LoadScene("result");
    }
    private void GameSceneScoreLoaded(Scene next, LoadSceneMode mode)
    {
        // �V�[���؂�ւ���̃X�N���v�g���擾
        var gameManager = GameObject.FindWithTag("GameManager").GetComponent<battle_judge>();
        var gameManager1 = GameObject.FindWithTag("GameManager").GetComponent<result_score>();

        // �f�[�^��n������
        gameManager.game_result = script_judge.judgement;
        gameManager1.score = scipt_score.score;

        // �C�x���g����폜
        SceneManager.sceneLoaded -= GameSceneScoreLoaded;

    }
}
