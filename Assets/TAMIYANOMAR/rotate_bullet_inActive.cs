using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_bullet_inActive : MonoBehaviour
{
    private GameObject parent;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            parent = transform.parent.gameObject;
            parent.SetActive(false);
        }
    }
}
