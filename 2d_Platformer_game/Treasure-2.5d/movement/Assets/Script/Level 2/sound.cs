using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sound : MonoBehaviour
{
   private AudioSource audio;
   public AudioClip key;
   public  int Key_no = 0;
   public Text text;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }



    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("key"))
        {
            print("yes");
            audio.PlayOneShot(key);
            Key_no ++;
            text.text = Key_no.ToString();
            print(Key_no);
            Destroy(other.gameObject);
        }
    }
}
