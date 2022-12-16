using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRandom : MonoBehaviour
{
    private float time;
    private float vecX;
    private float vecY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;

        if (time <= 0)
        {
            vecX = Random.Range(-4.5f, 5.0f);
            vecY = Random.Range(-4.5f, 5.0f);
            this.transform.position = new Vector2(vecX, vecY);
            time = 1.0f;
        }
    }
}
