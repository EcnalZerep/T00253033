using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SnowControlScript : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody rb;
    internal int check = 5;
    private bool hasHitFloor = false; //Created boolean variable
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

        //tag made connected to the plane
        if (collision.gameObject.CompareTag("Floor") && !hasHitFloor)  
        {
            hasHitFloor = true; 
            gameObject.SetActive(false); //Needs to be checked
        }

    }



    internal void ImThrowingYou(playerControl playerControl)
    {
        if (!hasHitFloor)
        {
            transform.position = playerControl.transform.position + 1 * Vector3.up + 2 * playerControl.transform.forward;
            rb = GetComponent<Rigidbody>();

            rb.velocity = 10 * (1.5f * Vector3.forward + 2 * playerControl.transform.forward);

        }

    }
}
