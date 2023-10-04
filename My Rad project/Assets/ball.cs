using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballControl : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody rb;
    internal int check = 5;
    void Start()
    {

        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 2, -4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void ImThrowingYou(CubeControlScript capsule)
    {
        transform.position = capsule.transform.position;
    }
}
