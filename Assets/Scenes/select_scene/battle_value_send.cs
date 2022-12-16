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
        // �C�x���g�ɓo�^
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
        // �V�[���؂�ւ���̃X�N���v�g���擾
        var gameManager = GameObject.FindWithTag("player_weapon").GetComponent<Pllayer_shoot>();
        var gameManager1 = GameObject.FindWithTag("player_weapon").GetComponent<weapon_type>();

        // �f�[�^��n������
        gameManager.select_weapon_number = script_weapon.use_weapon;

        // �C�x���g����폜
        SceneManager.sceneLoaded -= GameSceneScoreLoaded;

    }
}
