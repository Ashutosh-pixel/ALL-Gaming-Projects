using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHEST : MonoBehaviour
{
    Animator ani_m;
    AudioSource audio;
    public AudioClip chest;
    bool touch;
    public int chest_no = 0;
    // Start is called before the first frame update
    void Start()
    {
        ani_m = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
        touch = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(touch == true)
        {
            touch = false;
            switch (other.gameObject.tag) {
                case "player":
                {
                    chest_no++;
                    audio.PlayOneShot(chest);
                    ani_m.SetBool("open", true);
                    break;
                }
            }
        }
    }
}
