using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chest : MonoBehaviour
{
    AudioSource Audio;
    public AudioClip chestaudio;
   // public AudioClip chestsound;
    Animator animator;
    public movement a;
    public int treasure = 0;

    // Start is called before the first frame update
    void Start()
    {
        Audio = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       switch(collision.gameObject.tag)
        {
            case "player":
                {
                  

                    if (a.Key == 1)
                    {
                  
                        animator.SetBool("open", true);
                        Audio.PlayOneShot(chestaudio);
                        treasure = 1;
                    }

                    else
                    {
                        animator.SetBool("open",false);
                    }
                   
                    break;
                }
        }
    }
}
