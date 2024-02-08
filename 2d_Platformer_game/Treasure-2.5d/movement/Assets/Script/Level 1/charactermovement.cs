//using charactermovement;
using UnityEngine;
using UnityEngine.SceneManagement;
public class charactermovement : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    AudioSource Audio;
    public AudioClip jump4, faintsound;
    private bool Jumping = true;
    private bool Faint = true;
    public enum State {Alive,Transanding , Dead};
   private Vector2 Reswap1,Reswap2,Reswap3;
	State state = State.Alive;
	public int live = 1;
	public int Lives = 1;
	public flyboard fb;
	
   
    void Start()
    {
        anim = GetComponent<Animator>();
        Audio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (state == State.Alive)
        {
            if (Input.GetKey(KeyCode.D) || (Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.RightArrow) || (Input.GetKey(KeyCode.LeftArrow)))))
            {
                anim.SetBool("isRunning", true);
            }
            else
            {
                anim.SetBool("isRunning", false);
            }

            if (Input.GetKey(KeyCode.Space))
            {

                anim.SetTrigger("jump");
                if (Jumping == true)
                {
                    Audio.PlayOneShot(jump4);
                    Jumping = false;
                }
            }

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // if (collision.gameObject.CompareTag("faint"))
        switch (collision.gameObject.tag)
        {
        case "faint":
        {
            state = State.Dead;
            Audio.Stop();
            if(Faint == true)
            {
               if(Audio.isPlaying == false)
                        {
                            Audio.PlayOneShot(faintsound);
                        }  
            }
            anim.SetTrigger("faint");
             Invoke("dead", 3f);
             break;
        }
        case "Ground":
        {
                    Jumping = true;
                  
                    break;
        }
            case "faint2":
            {
                state = State.Dead;
                anim.SetTrigger("faint2");
                Invoke("dead", 2f);
                break;
            }

        }
    }
    void dead()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        switch(other.gameObject.tag)
        {
            case "checkpoint1":
            {
               Reswap1 = other.transform.position;
                break;
            }

            case "chainenemie":
            {
                state = State.Dead;
                Audio.Stop();
                if(Faint == true)
                {
                    if(Audio.isPlaying == false)
                    {
                        Audio.PlayOneShot(faintsound);
                    }
                }
                anim.SetTrigger("faint");
                Invoke("Reswap_1", 5f);
                break;
            }

            case "dead1":
            {
                transform.position = Reswap1;
                break;
            }
            case "checkpoint2":
            {
                Reswap2 = other.transform.position;
                break;
            }
            case "dead":
            {
                state = State.Dead;
                anim.SetTrigger("dead");
                Invoke("Reswap_2", 4f);
                break;
            }

            case "invisible":
            {
                transform.position = Reswap2;
                break;
            }
            case "checkpoint3":
            {
                Reswap3 = other.transform.position;
                break;
            }
            case "hook":
            {
              anim.SetTrigger("dead");
	            Invoke("Reswap_3",3f);
                break;
            }
            case "live":
	        {
	        	live =1;
	        	break;
	        }
            case "Lives":
	        {
	        	Lives =1;
	        	break;
	        }
            case "k":
	        {
		        Reswap_2();
	        	break;
	        }

        }
    }
    void Reswap_1()
    {
        gameObject.GetComponent<Animator>().Rebind();
        state = State.Alive;
        transform.position = Reswap1;
    }
    void Reswap_2()
	{
		//	fb.transform.position = Vector2.MoveTowards(fb.Flyboard_locations[0],fb.Flyboard_locations[0],fb.Flyboard_speed);
		if(live ==1)
		{
			gameObject.GetComponent<Animator>().Rebind();
			state = State.Alive;
			transform.position = Reswap2;
			live++;
			
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
