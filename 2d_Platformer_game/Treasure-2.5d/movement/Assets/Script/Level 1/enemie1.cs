using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemie1 : MonoBehaviour
{
    Rigidbody2D rb;
    public float EnemieSpeed;
    public Vector2 Endpoint;
    public float Distance;
    public LayerMask layermask;
    public Transform player;
    RaycastHit2D Detect1, Detect2;
    public float Yspeed = 10f;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       Detect1  = Physics2D.Raycast(transform.position, Endpoint, Distance, layermask);
       Detect2  = Physics2D.Raycast(transform.position, Endpoint, -Distance, layermask);
       Debug.DrawRay(transform.position, Endpoint, Color.blue);
       Touch();

    }
    void Chase()
    {
        if (transform.position.x < player.position.x)
        {

            rb.velocity = new Vector2(EnemieSpeed, 0);
           transform.localRotation = Quaternion.Euler(0, 0, 0);
           // anim.SetBool("isrunning", true);


        }
        else if (transform.position.x > player.position.x)
        {

            rb.velocity = new Vector2(-EnemieSpeed, 0);
            transform.localRotation = Quaternion.Euler(0, 180, 0);
          //  anim.SetBool("isrunning", true);

        }
        /* else if(transform.position.x == player.position.x)
         {
            // anim.SetTrigger("isattack");
             rb.AddForce(new Vector2(transform.position.x ,Yspeed));
        } */
    
    }
    void Stop()
    {
        
        rb.velocity = Vector2.zero;
    }

    void Touch()
    {
        if (Detect1.collider != null || Detect2.collider!= null)
        {
            Chase();
        }
        else
        {

            Stop();
        }
    }
  
}
