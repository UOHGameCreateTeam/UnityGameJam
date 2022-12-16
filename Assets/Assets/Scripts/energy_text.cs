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
        Player = GameObject.Find("Player"); //Player���I�u�W�F�N�g�̖��O����擾���ĕϐ��Ɋi�[����
        script = Player.GetComponent<player_status>();
    }

    // Update is called once per frame
    void Update()
    {
        if (script == null) // <- NULL�`�F�b�N���s���B
        {
            
            return; // <- ���̊֐����I�����܂��B
        }
        if (energyText == null)
        {
            
            return; // <- ���̊֐����I�����܂��B
        }
        energyText.text = script.energy.ToString();

    }
}
