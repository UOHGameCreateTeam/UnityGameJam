using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_behaib_damage : MonoBehaviour
{
    private void Start()
    {
    }
    // Update is called once per frame
    public int damage = 20;
    void Update()
    {
        // 5秒後に自分を削除
        Destroy(this.gameObject, 5.0f);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log($"{other.gameObject} has null player");
            // _attakTarget にセットされたオブジェクトから、IDamagable を呼ぶ
            var damagetarget = other.gameObject.GetComponent<IDamagable>();

            //IDamagable は AddDamage の処理が必須
            if (damagetarget != null)
            {
                other.gameObject.GetComponent<IDamagable>().AddDamage(damage);
                other.gameObject.GetComponent<IDamagable>().AddEnergy(damage);
            }
            Destroy(this.gameObject);
        }
    }
}
