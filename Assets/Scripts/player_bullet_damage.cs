using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_bullet_damage : MonoBehaviour
{
    private GameObject Player;
    player_status script;
    private void Start()
    {
        Player = GameObject.Find("Player"); //Player���I�u�W�F�N�g�̖��O����擾���ĕϐ��Ɋi�[����
        script = Player.GetComponent<player_status>();
    }
    // Update is called once per frame
    public int damage = 1;
    void Update()
    {
        // 5�b��Ɏ������폜
        Destroy(this.gameObject, 5.0f);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Enemy"))
        {
            // _attakTarget �ɃZ�b�g���ꂽ�I�u�W�F�N�g����AIDamagable ���Ă�
            var damagetarget = other.gameObject.GetComponent<EDmage>();

            //IDamagable �� AddDamage �̏������K�{
            if (damagetarget != null)
            {
                other.gameObject.GetComponent<EDmage>().AddDamage(damage);
                other.gameObject.GetComponent<EDmage>().AddScore(damage);
                if (script.hp == script.max_hp)
                {

                }
                else {
                    script.hp += damage;

                }

                Destroy(this.gameObject);

            }
        }
    }
}
