using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    private int hp = 10;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        hp--;
        if (hp <= 0)
        {
            this.gameObject.SetActive(false);
        }
    }
}
