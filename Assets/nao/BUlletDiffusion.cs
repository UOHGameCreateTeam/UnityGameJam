using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BUlletDiffusuion : MonoBehaviour
{
    private Vector3 velocity; //�@���x



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += velocity;
    }
}
