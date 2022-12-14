using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_beem_damage : MonoBehaviour
{
    private void Start()
    {
    }
    // Update is called once per frame
    private int damage = 1000;
    void Update()
    {
        // 5秒後に自分を削除
        Destroy(this.gameObject, 5.0f);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log($"GG");
            // _attakTarget にセットされたオブジェクトから、IDamagable を呼ぶ
            var damagetarget = other.gameObject.GetComponent<EDmage>();

            //IDamagable は AddDamage の処理が必須
            if (damagetarget != null)
            {
                other.gameObject.GetComponent<EDmage>().AddDamage(damage);
             
            }
        }
    }
}
