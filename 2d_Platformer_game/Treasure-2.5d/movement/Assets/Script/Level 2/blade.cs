using UnityEngine;

public class blade : MonoBehaviour
{
    Rigidbody2D rb;
    public Transform[] Blade_location;
    public float Blade_speed;
    private int Blade_random;
    public float Waittime , ReachTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Waittime = ReachTime;
        rb = GetComponent<Rigidbody2D>();
        Blade_random = Random.Range(0,Blade_location.Length);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position , Blade_location[Blade_random].position , Blade_speed);
        if(Vector2.Distance(transform.position,Blade_location[Blade_random].position) <= 0.2f)
        {
            if (Waittime <= 0)
            {
                Blade_random = Random.Range(0, Blade_location.Length);
                Waittime = ReachTime;
            }
            else
            {
                Waittime--;
            }
        }
    }
}
