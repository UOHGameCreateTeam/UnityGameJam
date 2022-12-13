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
        Player = GameObject.Find("Player"); //Player���I�u�W�F�N�g�̖��O����擾���ĕϐ��Ɋi�[����
        script = Player.GetComponent<player_hp>();
    }

    // Update is called once per frame
    void Update()
    {
        if (script == null) // <- NULL�`�F�b�N���s���B
        {
            Debug.Log($"{name_player} has null player"); // <- �Q�[���I�u�W�F�N�g�̖��O���L�^����B
            return; // <- ���̊֐����I�����܂��B
        }
        if (hpText == null)
        {
            Debug.Log($"{name_hptext} has null ui"); // <- �Q�[���I�u�W�F�N�g�̖��O���L�^����B
            return; // <- ���̊֐����I�����܂��B
        }
        hpText.text = script.hp.ToString();

    }
}
