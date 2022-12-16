using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_hp : MonoBehaviour
{
    private int hp = 3;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        hp--;
        if (hp <= 0)
        {
            this.gameObject.SetActive(false);
        }
    }
}
