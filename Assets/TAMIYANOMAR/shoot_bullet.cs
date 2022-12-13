using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot_bullet : MonoBehaviour
{
    public GameObject bullet;
    public GameObject muzzle;
    private float bullet_speed = 10f;
    private float time = 0f;
    private float move_speed = 3f;

    private float way = 0;
    private float move_timer = 0f;
    private float minimum_x = -8f;
    private float max_x = 8f;

    private float right = 0f;
    private float left = 2f;
    private float threshold = 1f;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        move_timer += Time.deltaTime;

        if (move_timer >= 1f)
        {
            way = define_way();
            move_timer = 0f;
        }
        move(way);

        if(time >= 0.5f)
        {
            time = 0f;
            GameObject new_bullet = Instantiate(bullet,muzzle.transform.position , transform.rotation);
            new_bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, bullet_speed * -1f);
        }
    }

    private void move(float way)
    {
        if (way < threshold)
        {
            this.transform.position = new Vector2(this.transform.position.x - Time.deltaTime * move_speed, this.transform.position.y);
        }
        else
        {
            this.transform.position = new Vector2(this.transform.position.x + Time.deltaTime * move_speed, this.transform.position.y);
        }
    }

    private float define_way()
    {
        float way = Random.Range(right, left);

        if (this.transform.position.x < minimum_x)
        {
            way = 2f;
        }
        else if (this.transform.position.x > max_x)
        {
            way = 0f;
        }

        return way;
    }
}
