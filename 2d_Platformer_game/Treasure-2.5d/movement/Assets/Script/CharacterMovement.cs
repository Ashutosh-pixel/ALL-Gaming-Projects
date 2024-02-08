using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed = 5f;
    public float force = 5f;

    private bool is_jump = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Run();
        Jump();
    }

    void Run()
    {
        float offset = Input.GetAxisRaw("Horizontal");
        float xoffset = offset * speed * Time.deltaTime;
        float x = transform.position.x + xoffset;
        transform.position = new Vector2(x, transform.position.y);
        if (offset >= 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (offset < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && is_jump == true)
        {
            rb.AddForce(new Vector2(transform.position.x, force));
            is_jump = false;

        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        switch (other.gameObject.tag)
        {
            case "Ground":
            {
                is_jump = true;
                break;
            }


        }

    }
}
