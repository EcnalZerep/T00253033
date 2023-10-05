using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowControlScript : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody rb;
    internal int check = 5;
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void ImThrowingYou(playerControl playerControl)
    {
        transform.position = playerControl.transform.position + 2 * Vector3.up + 3 * playerControl.transform.forward;
        rb = GetComponent<Rigidbody>();

        rb.velocity = 5 * (1 * Vector3.up + 1 * playerControl.transform.forward);


    }
}
