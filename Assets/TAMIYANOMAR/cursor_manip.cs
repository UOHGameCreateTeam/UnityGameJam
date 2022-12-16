using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursor_manip : MonoBehaviour
{
    private Vector2 mouse_position;
    void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {

        Vector2 mouse_position_gap = new Vector2((Input.mousePosition.x - mouse_position.x) / Screen.width * 20f, (Input.mousePosition.y - mouse_position.y) / Screen.height * 20f);
        if (this.transform.position.x + mouse_position_gap.x > -10f && this.transform.position.x + mouse_position_gap.x < 10f && this.transform.position.y + mouse_position_gap.y > -4f && this.transform.position.y + mouse_position_gap.y < 4f)
        {
            this.transform.position = new Vector2(this.transform.position.x + mouse_position_gap.x, this.transform.position.y + mouse_position_gap.y);
        }
        mouse_position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
    }
}
