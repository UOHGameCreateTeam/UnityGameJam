using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_move : MonoBehaviour
{
    public float move_speed = 10f;
    public float min_range = -5f;
    public float max_range = 5f;
    private int direction = 1;
    private Vector2 pos;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        if (pos.x <= min_range)
        {
            direction = 1;
            transform.Translate(transform.right * move_speed * Time.deltaTime * direction);

        }
        if (pos.x >= max_range)
        {
            direction = -1;
            transform.Translate(transform.right * Time.deltaTime * move_speed * direction);

        }
        transform.Translate(transform.right * move_speed * Time.deltaTime * direction);
    }
}
