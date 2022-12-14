using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_energy : MonoBehaviour
{
    public int energy = 0;
    public int max_energy = 100;
    public void AddEnergy(int damage)
    {
        if (energy + damage >= max_energy)
        {
            energy = max_energy;
            Debug.Log("MAX");
        }
        else {
            energy += damage;
        }
        Debug.Log("add: " + damage + "energy: " + energy);

        
    }
}
