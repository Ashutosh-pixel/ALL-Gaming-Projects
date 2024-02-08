using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sinewave : MonoBehaviour
{
    // Start is called before the first frame update
    public float amplitude = 5f;
    public float frequency = 5f;
    
    // Update is called once per frame
    void Update()
    {
        float x = transform.position.x;
        float y = (Mathf.Sin(Time.time * frequency) * amplitude) + transform.position.y;
        transform.position = new Vector2(x,y);
    }
}
