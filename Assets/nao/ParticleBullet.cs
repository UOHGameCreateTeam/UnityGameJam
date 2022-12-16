using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleBullet : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem ps;
    private ParticleSystem.Particle[] particles;
    GameObject enemy;


    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        enemy = GameObject.Find("enemy");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            particles = new ParticleSystem.Particle[ps.main.maxParticles];
            int numParticlesAlive = ps.GetParticles(particles);
            for (int i = 0; i < numParticlesAlive; i++)
            {
                particles[i].velocity = new Vector3(enemy.transform.position.x, enemy.transform.position.y, enemy.transform.position.z);
            }
            ps.SetParticles(particles, numParticlesAlive);
        }
    }
}
