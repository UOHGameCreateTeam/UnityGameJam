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
    public void AddEnergy(int damage)
    {
        if (energy + damage >= max_energy)
        {
            energy = max_energy;
            Debug.Log("MAX");
        }
        else
        {
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
        Debug.Log("add: " + damage + "energy: " + energy);


    }
    public void AddDamage(int damage)
    {
        hp -= damage;
        Debug.Log("add: " + damage + "hp: " + hp);

        if (hp <= 0)
        {
            this.gameObject.SetActive(false);
            SceneManager.LoadScene("result");
        }
    }
    
}
