using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public GameObject gb;
    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(gb);
    }
}
