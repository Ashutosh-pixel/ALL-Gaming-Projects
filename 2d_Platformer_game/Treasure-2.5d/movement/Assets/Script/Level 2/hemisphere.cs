﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hemisphere : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       // transform.localRotation = Quaternion.Euler(0,0,0);
}
}
