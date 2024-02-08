using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_platform : MonoBehaviour
{
    public float speed;
    public Vector2 Start_pos;
    public Vector2 End_pos;
    public float t;
    public float length;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.Lerp(Start_pos,End_pos,Mathf.PingPong(Time.time,length));
    }
}
