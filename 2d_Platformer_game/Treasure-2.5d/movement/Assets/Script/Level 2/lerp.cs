using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerp : MonoBehaviour {

    public Vector2 nextpos, startpos;
    public float speed;
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.Lerp(startpos,nextpos,Mathf.PingPong(Time.time,2));
       // rb.velocity = Vector2.Lerp(startpos,nextpos,Mathf.PingPong(Time.time,1));


    }
}