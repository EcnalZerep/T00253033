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

    private void OnCollisionEnter(Collision collision)
    {
        print("Ouch");

        DealWithHits thingIHit = collision.gameObject.GetComponent<DealWithHits>();
        if (thingIHit != null)
        {
            thingIHit.IHitYou();
        }

    }

    internal void ImThrowingYou(playerControl playerControl)
    {
        transform.position = playerControl.transform.position + 1 * Vector3.up + 2 * playerControl.transform.forward;
        rb = GetComponent<Rigidbody>();

        rb.velocity = 10 * (1.5f * Vector3.forward + 2 * playerControl.transform.forward);


    }
}
