﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   void OnCollisionEnter2D(Collision2D other)
   {
       if(other.gameObject.tag == "player")
       {
           anim.SetTrigger("bombing");
       }
   }
}
