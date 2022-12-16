using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTracking : MonoBehaviour
{
    GameObject Player;
    GameObject enemy;
    private float Speed = 2.0f;


    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        enemy = GameObject.Find("enemy2");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Vector2.MoveTowards(this.transform.position, new Vector2(Player.transform.position.x, Player.transform.position.y), Speed * Time.deltaTime);
    }
}
