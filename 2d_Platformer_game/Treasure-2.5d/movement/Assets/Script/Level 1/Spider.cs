using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Spider : MonoBehaviour
{
    public Transform[] enemielocations;
    public float enemiespeed = 4f;
    private int enemierandom;
    private int Waittime;
    public int StartWaittime;
  


    // Start is called before the first frame updater
    void Start()
    {
        
        Waittime = StartWaittime;
        enemierandom = Random.Range(0,enemielocations.Length);
    }
    // Update is called once per frame
    void Update()
    {
        if(enemierandom == 1)
        {
            transform.localRotation = Quaternion.Euler(0,180,0);
        }
        else
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        
        transform.position = Vector2.MoveTowards(transform.position,enemielocations[enemierandom].position , enemiespeed);
        if(Vector2.Distance(transform.position, enemielocations[enemierandom].position) <= 0.2f)
        {
            if(Waittime <= 0)
            {
                enemierandom = Random.Range(0, enemielocations.Length);
                Waittime = StartWaittime;
            }
            else
            {
                Waittime--;
            }
        }
    }
}
