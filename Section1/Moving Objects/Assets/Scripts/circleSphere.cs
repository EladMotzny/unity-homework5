using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleSphere : MonoBehaviour
{

    private Vector3 target = new Vector3(21.9f,2.8f,-66.8f);
    

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey("left"))
        {
            transform.RotateAround(target, Vector3.up, 30 * Time.deltaTime *3f );
        }
        if (Input.GetKey("right"))
        {
            transform.RotateAround(target, Vector3.up, -30 * Time.deltaTime *3f );
        }



    }
}
