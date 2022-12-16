using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_bullet_damage : MonoBehaviour
{

    // Update is called once per frame
    public int damage = 10;
    public float destroy_time = 5f;
    void Update()
    {
        // 5�b��Ɏ������폜
        Destroy(this.gameObject, destroy_time);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log($"rrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr");
            // _attakTarget �ɃZ�b�g���ꂽ�I�u�W�F�N�g����AIDamagable ���Ă�
            var damagetarget = other.gameObject.GetComponent<IDamagable>();

            //IDamagable �� AddDamage �̏������K�{
            if (damagetarget != null)
            {
                other.gameObject.GetComponent<IDamagable>().AddDamage(damage);
                other.gameObject.GetComponent<IDamagable>().AddEnergy(damage);
            }
            Destroy(this.gameObject);
        }
    }
}
