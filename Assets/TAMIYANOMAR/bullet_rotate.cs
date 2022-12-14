using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_rotate : MonoBehaviour
{
    private float rotate_speed = 1;
    void Update()
    {
        this.transform.rotation = new Quaternion(this.transform.rotation.x, this.transform.rotation.y , this.transform.rotation.z + (rotate_speed * Time.deltaTime), this.transform.rotation.w );
        Debug.Log(this.transform.rotation.z);
        if(this.transform.rotation.z == 1)
        {
            this.transform.rotation = new Quaternion(this.transform.rotation.x, this.transform.rotation.y,-1, this.transform.rotation.w);
        }
    }
}
