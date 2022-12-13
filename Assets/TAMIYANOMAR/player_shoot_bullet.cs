using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_shoot_bullet : MonoBehaviour
{
    public GameObject player_bullet;
    public GameObject player_muzle;
    private float bullet_speed = 20f;
    void Start()
    {
        
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject new_bullet = Instantiate(player_bullet, player_muzle.transform.position, transform.rotation);
            new_bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, bullet_speed * 1f);
        }
    }
}
