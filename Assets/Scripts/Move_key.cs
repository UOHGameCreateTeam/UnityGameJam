using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move_key : MonoBehaviour
{
    public float speed = 1;
    float x_Speed = 0;
    float y_Speed = 0;

    // 画面の左・右・上・下の境界の位置
    private float border_Left;
    private float border_Right;
    private float border_Uppor;
    private float border_Lower;

    private void Start()
    {

        // あらかじめ、画面上下左右の縁がワールド空間上でどこに位置するか調べておく
        Camera mainCamera = Camera.main;
        Vector3 upper_Right = mainCamera.ViewportToWorldPoint(new Vector3(1.0f, 1.0f, 0));
        Vector3 lower_Left = mainCamera.ViewportToWorldPoint(new Vector3(0.0f, 0.0f, 0));
        border_Left = lower_Left.x;
        border_Right = upper_Right.x;
        border_Uppor = upper_Right.y;
        border_Lower = lower_Left.y;
    }

    void Update()
    {
        // 毎フレーム数値を初期化
        x_Speed = 0;
        y_Speed = 0;
        float next_Position_x = 0;
        float next_Position_y = 0;
        Transform player_Transform = this.transform;
        Vector2 pos = player_Transform.position;
        // 横移動
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            x_Speed = -speed;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            x_Speed = speed;
        }

        // 縦移動
        if (Input.GetKey(KeyCode.UpArrow))
        {
            y_Speed = speed;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            y_Speed = -speed;
        }
        next_Position_x = pos.x + x_Speed * Time.deltaTime;
        next_Position_y = pos.y + y_Speed * Time.deltaTime;
        // 実際の移動処理
        transform.position = new Vector2(
             //エリア指定して移動する
             Mathf.Clamp(next_Position_x, border_Left, border_Right),
             Mathf.Clamp(next_Position_y, border_Lower, border_Uppor)
             );
    }
}
