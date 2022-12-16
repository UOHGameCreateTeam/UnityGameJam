using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_bullet_damage : MonoBehaviour
{
    private GameObject Player;
    player_status script;
    private void Start()
    {
        Player = GameObject.Find("Player"); //Playerをオブジェクトの名前から取得して変数に格納する
        script = Player.GetComponent<player_status>();
    }
    // Update is called once per frame
    public int damage = 1;
    void Update()
    {
        // 5秒後に自分を削除
        Destroy(this.gameObject, 5.0f);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Enemy"))
        {
            // _attakTarget にセットされたオブジェクトから、IDamagable を呼ぶ
            var damagetarget = other.gameObject.GetComponent<EDmage>();

            //IDamagable は AddDamage の処理が必須
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
