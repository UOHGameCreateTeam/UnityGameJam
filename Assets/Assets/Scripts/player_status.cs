 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_status : MonoBehaviour, IDamagable
{
    public int hp = 500;
    public int energy = 0;
    public int max_energy = 100;
    public int max_hp = 500;
    public GameObject player_score;
    score_board script;

    public bool charged = false;
    void Start()
    {
        //Playerをオブジェクトの名前から取得して変数に格納する
        script = player_score.GetComponent<score_board>();
    }
    public void AddEnergy(int damage)
    {
        if (energy + damage >= max_energy)
        {
            charged = true;
            energy = max_energy;
            Debug.Log("MAX");            
        }
        else
        {
            charged = false;

            if (hp <= max_hp / 3 * 2)
            {
                energy += damage * 4;
            }
            else if (hp <= max_hp / 3)
            {
                energy += damage * 8;
            }
            else
            {
                energy += damage;
            }
            
        }
        


    }
    public void AddDamage(int damage)
    {
        hp -= damage;

        if (hp <= 0)
        {
            this.gameObject.SetActive(false);
            GetComponent<result_value_send>().enabled = true;
            var a = new result_value_send();
        }
    }

    public void AddScore(int damage)
    {
        script.score += damage;
    }

}
