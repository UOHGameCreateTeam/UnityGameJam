using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_status : MonoBehaviour, EDmage
{
    public int hp = 500;
    
    public void AddDamage(int damage)
    {
        hp -= damage;
        Debug.Log("add: " + damage + "hp: " + hp);

        if (hp <= 0)
        {
            this.gameObject.SetActive(false);
            Debug.Log("Enemy��|����");
        }
    }
}
