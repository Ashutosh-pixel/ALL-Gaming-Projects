using UnityEngine;

public class SPRING : MonoBehaviour
{

    public Animator anim;
    public bool fly;

    // Start is called beforethe first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {


        switch (other.gameObject.tag)
        {


            case "player":
            {
                fly = true;
                anim.SetBool("isspring",true);
                break;
            }

        }



    }
}
