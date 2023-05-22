using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_bullet : MonoBehaviour
{
    public GameObject bullet;
    
    public GameObject muzzle;
    private float bullet_speed = 10f;
    private float time = 0f;
    public float bullet_timer = 0.5f;
    


    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= bullet_timer)
        {
            time = 0f;
            GameObject new_bullet = Instantiate(bullet, muzzle.transform.position, transform.rotation);
            new_bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, bullet_speed * -1f);
        }
        
    }

}
