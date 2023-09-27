using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsule : MonoBehaviour
{
    Rigidbody myRB;
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            myRB.AddForce(transform.forward);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            myRB.AddExplosionForce(5,transform.forward + Vector3.down, 5);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += Vector3.up * 10 * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up, 90 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.up, -90 * Time.deltaTime);
        }





        if (Input.GetKeyDown(KeyCode.P))
            transform.position = new Vector3(0, 0, 0);
    }
}
