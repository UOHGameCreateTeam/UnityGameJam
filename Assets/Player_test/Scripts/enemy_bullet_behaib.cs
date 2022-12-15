using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_bullet_behaib : MonoBehaviour
{
    private GameObject player_obj;
    public GameObject bullet1;
    public GameObject muzzle;
    public float bullet_speed = 10f;
    public string player_name = "Player";
    private float gap_x;
    private float gap_y;
    private float time = 0f;
    public float bullet_timer = 0.3f;
    private Vector2 vec;
    void Start()
    {
        player_obj = GameObject.Find(player_name);
    }

    void Update()
    {
        time += Time.deltaTime;

        if (time >= bullet_timer)
        {
            time = 0f;
            gap_x = player_obj.transform.position.x - this.transform.position.x;
            gap_y = player_obj.transform.position.y - this.transform.position.y;
            vec = new Vector2(gap_x, gap_y);
            Vector2 norm_vec = vec.normalized;
            GameObject new_bullet = Instantiate(bullet1, muzzle.transform.position, transform.rotation);
            new_bullet.GetComponent<Rigidbody2D>().velocity = norm_vec * bullet_speed;
        }
    }   

}
