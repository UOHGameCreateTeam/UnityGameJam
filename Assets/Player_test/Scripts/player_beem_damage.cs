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
        // 5�b��Ɏ������폜
        Destroy(this.gameObject, 5.0f);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log($"GG");
            // _attakTarget �ɃZ�b�g���ꂽ�I�u�W�F�N�g����AIDamagable ���Ă�
            var damagetarget = other.gameObject.GetComponent<EDmage>();

            //IDamagable �� AddDamage �̏������K�{
            if (damagetarget != null)
            {
                other.gameObject.GetComponent<EDmage>().AddDamage(damage);
             
            }
        }
    }
}
