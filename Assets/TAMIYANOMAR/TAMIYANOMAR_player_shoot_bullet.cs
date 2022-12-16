using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TAMIYANOMAR
{
    public class TAMIYANOMAR_player_shoot_bullet : MonoBehaviour
    {
        public GameObject player_bullet;
        public GameObject player_muzle;
        private float bullet_speed = 20f;

        static private float timer_max = 0.05f;
        private float timer = timer_max;
        void Update()
        {
            timer -= Time.deltaTime;
            if (Input.GetKey(KeyCode.Mouse0))
            {
                if (timer < 0)
                {
                    timer = timer_max;
                    GameObject new_bullet = Instantiate(player_bullet, player_muzle.transform.position, transform.rotation);
                    new_bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, bullet_speed * 1f);
                }

            }
        }
    }
}
