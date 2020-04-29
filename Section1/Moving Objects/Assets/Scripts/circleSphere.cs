using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleSphere : MonoBehaviour
{

    private Vector3 target = new Vector3(21.9f,2.8f,-66.8f);
    [Tooltip("Movement speed in meters per second")] [SerializeField] float speed = 100f;


    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey("left"))
        {
            transform.RotateAround(target, Vector3.up, speed * Time.deltaTime );
        }
        if (Input.GetKey("right"))
        {
            transform.RotateAround(target, Vector3.up, -speed * Time.deltaTime );
        }



    }
}
