using UnityEngine;
using UnityEngine.SceneManagement;

public class gate : MonoBehaviour
{
    public CHEST cs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void  OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("player"))
        {
            if(cs.chest_no!=0)
            {
                Invoke("next_level",2f);
            }
        }
    }

    void next_level()
    {
        SceneManager.LoadScene("Thanks");
    }
}
