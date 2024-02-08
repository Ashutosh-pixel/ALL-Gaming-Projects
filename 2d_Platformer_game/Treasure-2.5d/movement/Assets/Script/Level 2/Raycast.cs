
using UnityEngine;

public class Raycast : MonoBehaviour {


    public Vector2 endpoint;
    public float distance;
    public LayerMask layer_mask;
    public float speed;
    public bool ray_cast1,ray_cast2;
    public Transform[] player;
    Rigidbody2D rb;
    public Transform Player;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ray_cast1 = Physics2D.Raycast(transform.position, endpoint, distance, layer_mask);
        ray_cast2 = Physics2D.Raycast(transform.position, endpoint, -distance, layer_mask);
        Move_towards();
    }

    void Move_towards()
    {
        if(ray_cast1 == true || ray_cast2 == true)
        {
            if(Player.position.x>transform.position.x)
            {
                print("right");
               //  rb.velocity = new Vector2(speed*Time.time,0);
                //transform.position = Vector2.MoveTowards(transform.position, player[0].position, speed);
                transform.Translate(speed*Time.deltaTime,0,0);
                //transform.position = Vector2.Lerp(transform.position,player[0].position,speed);
            }
            else if(Player.position.x<transform.position.x)
            {
                print("left");
               // rb.velocity = new Vector2(speed*Time.time,0);
               // transform.position = Vector2.MoveTowards(transform.position, player[0].position, speed);
               transform.Translate(-speed*Time.deltaTime,0,0);
               // transform.position = Vector2.Lerp(transform.position,player[0].position,speed);

            }
        }
    }
}
