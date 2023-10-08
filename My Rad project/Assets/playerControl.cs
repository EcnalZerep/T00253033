using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class playerControl : MonoBehaviour
{

    public GameObject Snowball;

    Rigidbody myRB;
    private Camera mainCamera;
    private bool isGrounded;

    void Start()
    {
        myRB = GetComponent<Rigidbody>();
        myRB.freezeRotation = true;
        mainCamera = FindAnyObjectByType<Camera>();
        isGrounded = true;
    }

    // Update is called once per frame
    void Update() 
    {
            

        if (Input.GetKey(KeyCode.W)) 
        { 
            transform.position += transform.forward * 5 * Time.deltaTime; 
        }

        if (Input.GetKey(KeyCode.A))
        { 
            transform.position += Vector3.left * 5 * Time.deltaTime; 
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * 5 * Time.deltaTime; 
        }

        if (Input.GetKey(KeyCode.D))
        { 
            transform.position += Vector3.right * 5 * Time.deltaTime; 
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) 
        { 
            myRB.AddForce(transform.up * 1000, ForceMode.Force);
            isGrounded = true;
        }

        //Snowball
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newGO = Instantiate(Snowball);

            SnowControlScript mySnowball = newGO.GetComponent<SnowControlScript>();

            mySnowball.ImThrowingYou(this);
        }




        Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
        float rayLength;

        if(groundPlane.Raycast(cameraRay, out rayLength))

        {
            Vector3 pointtoLook = cameraRay.GetPoint(rayLength);
            Debug.DrawLine(cameraRay.origin, pointtoLook, Color.blue);

            transform.LookAt(new Vector3(pointtoLook.x, transform.position.y, pointtoLook.z)); 
        }




    }

}