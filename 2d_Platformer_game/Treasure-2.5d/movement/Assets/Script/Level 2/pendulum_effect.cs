using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pendulum_effect : MonoBehaviour {
    Rigidbody2D rb;
    public float Right_angle;
    public float Left_angle;
    public float speed;
    public float counter;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.angularVelocity = speed;

    }

    void Update()
    {
       if(transform.rotation.z > 0 && rb.angularVelocity > 0)
       {
           rb.angularVelocity = speed;
       }
        else if(transform.rotation.z <0 && rb.angularVelocity<0)
       {
           rb.angularVelocity = -speed;
       }

    }
}
