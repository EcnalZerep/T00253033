using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour
{

    public Transform target;
    public float speed = 4f;
    Rigidbody rig;


    // Start is called before the first frame update
    void Start()
    {
        rig=GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //makes the enemy run towards the Player
        Vector3 pos=Vector3.MoveTowards(transform.position, target.position, speed * Time.fixedDeltaTime);
        rig.MovePosition(pos);
        transform.LookAt(target);
        





    }
}
