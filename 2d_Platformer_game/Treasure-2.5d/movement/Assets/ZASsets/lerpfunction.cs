using UnityEngine;

public class lerpfunction : MonoBehaviour
{
    public float speed;
   [SerializeField] [Range(0,1)] float time;
    public Vector2 pos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector2.Lerp(transform.position ,pos, time);
        Debug.Log(transform.position = Vector2.MoveTowards(transform.position ,pos,speed));
        //Debug.Log(transform.position);
      //  Debug.Log(Time.deltaTime*speed);
    }
}
