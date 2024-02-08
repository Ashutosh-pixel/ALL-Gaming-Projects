using System.Diagnostics;
using UnityEngine;

public class Stairs : MonoBehaviour {
    public Transform[] Stairslocations;
    private int StairsRandom;
    public float speed;
    private Rigidbody2D rb;
    public float Waittime, ReachTime = 200f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.L))
        {
            transform.position = Vector2.MoveTowards(transform.position, Stairslocations[0].position, speed);
            Waittime = ReachTime;
        }
        else
        {
            Waittime--;
            back();
        }
    }

    void back()
    {
        if (Waittime <= 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, Stairslocations[1].position, speed);

        }
    }
}

