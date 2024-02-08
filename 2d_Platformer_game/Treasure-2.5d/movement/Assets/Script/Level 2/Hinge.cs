using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hinge : MonoBehaviour
{
    private HingeJoint2D _hinge;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        _hinge = GetComponent<HingeJoint2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _hinge.motor.motorSpeed.Equals(time);
        transform.localPosition = Vector3.back;

    }
}
