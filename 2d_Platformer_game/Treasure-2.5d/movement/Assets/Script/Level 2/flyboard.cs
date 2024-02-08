using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyboard : MonoBehaviour
{
     public float Flyboard_speed;
     public Transform[] Flyboard_locations;
   public Rigidbody2D rb;
    public SPRING sp;
	public float Flyboardnegative;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if(sp.fly == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, Flyboard_locations[1].position, Flyboard_speed);
        }
    }

}
