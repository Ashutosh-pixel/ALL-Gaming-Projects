using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingplatform1 : MonoBehaviour
{
	public float speed;
	private Rigidbody2D rb;
	public int Amplitude;
	public float frequency;
	// Start is called before the first frame update
    void Start()
    {
	    rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
	{
		float x = transform.position.x;
	    // float x = Mathf.Tan(Time.time*frequency)*Amplitude + 142;
		float y = Mathf.Tan(Time.time*frequency)*Amplitude + 0.7f;
	    // float y = transform.position.y;
	    float z = transform.position.z;
	    transform.position = new Vector3(x,y,z);
    }
}
