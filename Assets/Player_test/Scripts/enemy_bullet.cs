using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_bullet : MonoBehaviour
{
    public GameObject bullet;
    public GameObject muzzle;
    private float bullet_speed = 10f;
    private float time = -1f;
    private float move_timer = 0f;
    
    
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        move_timer += Time.deltaTime;

        if (time >= 0.5f)
        {
            time = 0f;
            GameObject new_bullet = Instantiate(bullet, muzzle.transform.position, transform.rotation);
            new_bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, bullet_speed * -1f);
        }
    }

}
