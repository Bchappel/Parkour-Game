using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackForthMovement : MonoBehaviour
{

    public float speed = 2.5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move cube from (11.48 , 301,45 , 212.58) to (20.72, 301,45 , 212.58) then back to (11.48 , 301,45 , 212.58)

        transform.position = new Vector3(Mathf.PingPong(Time.time * speed, 9), transform.position.y, transform.position.z);


    }
}
