using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemiepetrol : MonoBehaviour
{
    public Transform[] EnemieLocations;
    private int EnemieRandom;
    private Rigidbody2D rb;
    public  float speed = 1f;
    public float Waittime , ReachTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Waittime = ReachTime;
        rb = GetComponent<Rigidbody2D>();
        EnemieRandom = Random.Range(0,EnemieLocations.Length);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position , EnemieLocations[EnemieRandom].position , speed);

        if(EnemieRandom == 0f)
        {
            transform.eulerAngles = new Vector3(0,0,0);
        }
        else
        {
            transform.eulerAngles = new Vector3(0,180,0);
        }
        if(Vector2.Distance(transform.position,EnemieLocations[EnemieRandom].position) <= 0.2f)
        {
            if (Waittime <= 0)
            {
                EnemieRandom = Random.Range(0, EnemieLocations.Length);
                Waittime = ReachTime;
            }
            else
            {
                Waittime--;
            }
        }
    }
}
