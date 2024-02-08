using UnityEngine;

public class pushbutton1 : MonoBehaviour
{
    private Animator anim;
    public  hemisphere hemi;
    private bool ispushing = true;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        hemi.GetComponent<BoxCollider2D>().isTrigger = true;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        anim.SetBool("onbutton",false);
     //   hemi.transform.localRotation = Quaternion.Euler(0,0,180);

        if(other.gameObject.CompareTag("player"))
        {

            hemi.GetComponent<BoxCollider2D>().isTrigger = false;

            anim.SetBool("onbutton",true);
            if(ispushing == true)
            {
                push();
            }
            
        }
    }
        void push()
        {

            hemi.transform.localRotation = Quaternion.Euler(0,0,0);

        }
}

