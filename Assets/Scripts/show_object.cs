using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class show_object : MonoBehaviour
{
    public GameObject show_hp;
    public GameObject show_enrgy;
    public GameObject show_panel;
    public GameObject show_select_wp;
    public GameObject show_count_down;
    public GameObject show_time_limit;
    public GameObject show_player;
    public GameObject show_enemy;
    public GameObject show_gameobject;
    // Start is called before the first frame update
    void Start()
    {
        show_hp.SetActive(false);
        show_enrgy.SetActive(false);
        show_select_wp.SetActive(false);
        show_time_limit.SetActive(false);
        show_player.SetActive(false);
        show_enemy.SetActive(false);
        show_gameobject.SetActive(false);
        show_panel.SetActive(true);
        show_count_down.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        float tmp;
        tmp = timer_control.Get_Timer();
        if (tmp >= 0)
        {
            show_hp.SetActive(true);
            show_enrgy.SetActive(true);
            show_select_wp.SetActive(true);
            show_time_limit.SetActive(true);
            show_player.SetActive(true);
            show_enemy.SetActive(true);
            show_gameobject.SetActive(true);
            show_panel.SetActive(false);
            show_count_down.SetActive(false);
        }

    }
}
