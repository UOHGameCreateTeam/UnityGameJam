using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pllayer_shoot : MonoBehaviour
{
    public GameObject player;
    public GameObject player_bullet;
    public GameObject player_beem;
    public float bullet_speed = 3f;
    public float beem_speed = 3f;
    public float angle = 0f;
    private GameObject Player;
    player_status script;
    public float bullet_sense = 0f;
    private float time = 0;
    public AudioClip sound1;
    public AudioClip sound2;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        time = bullet_sense;
        Player = GameObject.Find("Player"); //Playerをオブジェクトの名前から取得して変数に格納する
        script = Player.GetComponent<player_status>();
        audioSource = GetComponent<AudioSource>();
    }

    public static Vector2 AngleToVector2(float angle)
    {
        var radian = angle * (Mathf.PI / 180);
        return new Vector2(Mathf.Cos(radian), Mathf.Sin(radian)).normalized;
    }
    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKey(KeyCode.C))
        {
            Debug.Log($"{transform.rotation}");
            Debug.Log($"{transform.rotation}");
            GameObject new_bullet = Instantiate(player_bullet, player.transform.position, transform.rotation);
            var a = AngleToVector2(angle);
            var angles = new_bullet.transform.localEulerAngles;
            angles.z = angle - 90f;
            new_bullet.transform.localEulerAngles = angles;
            new_bullet.GetComponent<Rigidbody2D>().velocity = a * bullet_speed;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            if(script.energy == script.max_energy)
            {
                GameObject new_bullet = Instantiate(player_beem, player.transform.position, transform.rotation);
                new_bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, beem_speed);
                script.energy = 0;
                audioSource.PlayOneShot(sound2);
            }
        }
        if (Input.GetKey(KeyCode.Z))
        {
            if (time >= bullet_sense)
            {
                GameObject new_bullet = Instantiate(player_bullet, player.transform.position, transform.rotation);
                new_bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, bullet_speed);
                time = 0f;
                audioSource.PlayOneShot(sound1);
            }

        }
        time += Time.deltaTime;
    }
}
