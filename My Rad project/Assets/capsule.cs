using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CubeControlScript : MonoBehaviour
{

    GameObject snowballCloneTemplate;

    Rigidbody myRB;
    private Camera mainCamera;

    void Start()
    {
        myRB = GetComponent<Rigidbody>();
        myRB.freezeRotation = true;
        mainCamera = FindAnyObjectByType<Camera>();
    }

    // Update is called once per frame
    void Update() 
    {
        

        if (Input.GetKey(KeyCode.W)) { transform.position += transform.forward * Time.deltaTime; }

        if (Input.GetKey(KeyCode.A)) { transform.position += Vector3.left * Time.deltaTime; }

        if (Input.GetKey(KeyCode.S)) { transform.position -= transform.forward * Time.deltaTime; }

        if (Input.GetKey(KeyCode.D)) { transform.position += Vector3.right * Time.deltaTime; }

        if (Input.GetKey(KeyCode.Space)) { myRB.AddForce(transform.up * 10, ForceMode.Force); }


        //Snowball
        if (Input.GetMouseButton(0)) 
        { 
            GameObject newGO = Instantiate(snowballCloneTemplate); 
            SnowballControl mySnowball = newGO.GetComponent<SnowballControl>();

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