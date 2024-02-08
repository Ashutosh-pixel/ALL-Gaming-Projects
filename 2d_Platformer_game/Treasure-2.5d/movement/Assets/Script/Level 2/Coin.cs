using System;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public  int coin = 0;
    public Text textcoin;
    private AudioSource audio;
    public AudioClip coin_sound;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("coin"))
        {
            audio.PlayOneShot(coin_sound);
            coin++;
            textcoin.text = coin.ToString();
            Destroy(other.gameObject);

        }
    }
}
