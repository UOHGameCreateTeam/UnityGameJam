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
        // 5�b��Ɏ������폜
        Destroy(this.gameObject, 5.0f);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log($"{other.gameObject} has null player");
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
