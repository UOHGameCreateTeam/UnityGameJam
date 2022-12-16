using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    [SerializeField]
    private Vector3 mouse;
    private Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouse = Input.mousePosition;
        target = Camera.main.ScreenToViewportPoint(new Vector3(mouse.x, mouse.y, 0));
        this.transform.position = target;
    }
}
