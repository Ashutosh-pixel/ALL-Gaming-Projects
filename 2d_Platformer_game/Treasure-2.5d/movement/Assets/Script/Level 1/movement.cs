using Cinemachine;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    private Rigidbody2D rb;
    public float Xspeed = 10f;
    public float Yspeed, speed = 10f;
    private AudioSource Audio;
    public AudioClip coin;
    public AudioClip faintsound;
    public AudioClip key;
    public int Coin,Key = 0;
    public Text Textcoin, Textkey;
    private bool isjumping = true;
    private enum State { Alive, Transanding, Dead };
    State state = State.Alive;
    private bool Faint = true;
    private Vector3 Reswap,Reswap2,Reswap3,Reswap4;
	public int lives = 1;
	public int Lives = 1;
 
    //call at the first frame
    void Start()
    {
	    rb = GetComponent<Rigidbody2D>();
        Audio = GetComponent<AudioSource>();
	    anim = GetComponent<Animator>();
	    
    }

    // Update is called once per frame
    void Update()
    {

            if (state == State.Alive)
            {
                Charactermove();
            }
   

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "coin":
                {
                    Audio.Stop();
                    Audio.PlayOneShot(coin);
                    Coin++;
                    Textcoin.text = Coin.ToString();
                    Destroy(collision.gameObject);
                    break;
                }
            case "key":
                {
                    Audio.Stop();
                    Audio.PlayOneShot(key);
                    Key++;
                    Textkey.text = Key.ToString();
                    Destroy(collision.gameObject);
                    break;
                }
            case "flag":
            {
                Reswap = collision.transform.position;
                break;
            }
           case "dead":
           {

               transform.position = Reswap;
               break;
           }
            case "checkpoint":
            {
	            Reswap2 = collision.transform.position;
	           
                break;
            }
            case "faint":
	        {
		      
		        
                state = State.Dead;
              
                Audio.Stop();
	             if (Faint == true)
	             {
                    if (Audio.isPlaying == false)
                    {
                        Audio.PlayOneShot(faintsound);
                    }
	             }  
                anim.SetTrigger("faint");
	            Invoke("Reswap_2", 4f);
		        
                break;
            }
            case "water":
            {
	            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	           
                break;
            }
            case "checkpoint2":
            {

               Reswap3 = collision.transform.position;
                break;
            }
            case "larva":
            {
                state = State.Dead;

             //   gd.SetActive(value);
                Audio.Stop();
                if (Faint == true)
                {
                    if (Audio.isPlaying == false)
                    {
                        Audio.PlayOneShot(faintsound);
                    }
                }
                anim.SetTrigger("faint");
               Invoke("Reswap_3",5f);
                break;
            }
            case "live":
	        {
	        	lives = 1;
	        	break;
	        }
            case "Lives":
	        {
	        	Lives = 1;
	        	break;
	        }

        }
    }
    private void Charactermove()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float Xoffset = horizontal * Xspeed * Time.deltaTime;
        float Xmove = Xoffset + transform.position.x;
        if (horizontal >= 0)
        {
            // transform.eulerAngles = new Vector3(0,0,0);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            // transform.eulerAngles = new Vector3(0,180,0);
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        transform.position = new Vector2(Xmove, transform.position.y);
        CharacterJump();
    }
    void CharacterJump()
    {
        if (Input.GetButtonDown("Jump") && isjumping == true)
        {
            rb.AddForce(new Vector2(transform.position.x, Yspeed));
            isjumping = false;   //if isjumping = true then Character is jump again and again during jump

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Ground":
                {
                    isjumping = true;
                 //  GetComponent<Animator>().enabled = true;
                    break;
                }

        }

    }
    void Reswap_2()
	{
		
		if(lives==1)
		{
			gameObject.GetComponent<Animator>().Rebind();
			
			
		
      
      // gd.SetActive(value);
		state = State.Alive;
		
			transform.position = Reswap2;
			lives++;
       //GetComponent<Animator>().enabled = false;

		}
		
		
    }

    void Reswap_3()
    {
	    if(Lives == 1)
	    {
        gameObject.GetComponent<Animator>().Rebind();
        state = State.Alive;
		    transform.position = Reswap3;
		    Lives++;
	    }
    }

}      