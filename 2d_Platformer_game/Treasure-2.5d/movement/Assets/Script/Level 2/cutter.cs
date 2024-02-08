using UnityEngine;

public class cutter : MonoBehaviour
{
    public AudioClip Cutter;
    public AudioSource audio;
[Range(0,1)] public float volume;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }


    void OnCollisionEnter2D(Collision2D other)
    {
        switch (other.gameObject.tag)
        {
            case "player":
            {
                audio.Stop();
                audio.PlayOneShot(Cutter,volume);
                break;
            }
        }
    }
}
