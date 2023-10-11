using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour
{

     Transform target;
    public float speed = 4f;
 


    // Start is called before the first frame update
    void Start()
    {
        playerControl player = FindObjectOfType<playerControl>();
        target = player.transform;
       
    }

    // Update is called once per frame
    void Update()
    {

        transform.LookAt(target);
        //makes the enemy run towards the Player
        // Vector3 pos=Vector3.MoveTowards(transform.position, target.position, speed * Time.fixedDeltaTime);
        transform.position += transform.forward * speed * Time.deltaTime;
  
        





    }
}
