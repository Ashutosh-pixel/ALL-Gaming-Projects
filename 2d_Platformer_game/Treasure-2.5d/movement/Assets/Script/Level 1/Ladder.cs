using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    Rigidbody2D rb;
    bool isclimbing;
    public Vector2 Endposition;
    public float Distance = 10f;
    public float Speed = 10f;
    public LayerMask layermask;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Raycast2D();
    }
        void Raycast2D()
        {
            Debug.DrawRay(transform.position, Endposition, Color.blue);
            //  Detect = Physics2D.Raycast(transform.position , Endposition , Distance , 1 << LayerMask.NameToLayer("Ladder"), 2<< LayerMask.NameToLayer("Stone"));
            RaycastHit2D Detect = Physics2D.Raycast(transform.position, Endposition, Distance, layermask);
          
            if (Detect.collider != null)
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    isclimbing = true;

                }
                else
                {
                    isclimbing = false;
                }




            }
            if (isclimbing == true)
            {

                float vertical = Input.GetAxis("Vertical");
                rb.velocity = new Vector2(rb.velocity.x, vertical * Speed * Time.deltaTime);
                // rb.AddForce(Vector2.up * Speed * Time.deltaTime);
                //transform.position = new Vector2(transform.position.x , vertical*Speed*Time.deltaTime);
                rb.gravityScale = 10;
            }
            else
            {
                rb.gravityScale = 3;
            }
        }
}
