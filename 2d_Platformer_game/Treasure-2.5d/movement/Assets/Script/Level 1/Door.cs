using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{

    public chest movement;
    private AudioSource Audio;
    public AudioClip door;
    // Start is called before the first frame update
    void Start()
    {
        Audio = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("player"))
        {
            if(movement.treasure == 1)
            {
                Audio.PlayOneShot(door);
                Invoke("loadsceen" , 3f);
            }
        }
    }

    void loadsceen()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
