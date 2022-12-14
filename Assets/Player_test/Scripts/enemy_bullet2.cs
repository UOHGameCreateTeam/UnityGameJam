using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_bullet2 : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject bullet3;
    public GameObject muzzle;
    public float bullet_speed = 10f;
    private float time = 0f;
    public float bullet_timer = 0.5f;
    private float angle;
    public float angle_change = -90f;
    public float min_angle = -70f;
    public float max_angle = 70f;
    public int count = 3;
    public static Vector2 AngleToVector2(float angle)
    {
        var radian = angle * (Mathf.PI / 180);
        return new Vector2(Mathf.Cos(radian), Mathf.Sin(radian)).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        
        time += Time.deltaTime;

        if (time >= bullet_timer)
        {
            time = 0f;
            for (int i = 0; i < count; i++)
            {
                float angle = Random.Range(min_angle, max_angle);
                GameObject new_bullet = Instantiate(bullet3, Enemy.transform.position, transform.rotation);
                var a = AngleToVector2(angle);
                var angles = new_bullet.transform.localEulerAngles;
                angles.z = angle + angle_change;
                new_bullet.transform.localEulerAngles = angles;
                new_bullet.GetComponent<Rigidbody2D>().velocity = a * bullet_speed;
            }
            
        }

    }
}
