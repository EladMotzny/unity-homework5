using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleSphere : MonoBehaviour
{

    float timeCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        timeCounter += Time.deltaTime;


        float x = 13f;
        float y = 1;
        float z = 0;

        if (Input.GetKey("left"))
        {
            x = Mathf.Cos(timeCounter) * 4f + 13f;
            z = Mathf.Sin(timeCounter) * 4f;
            transform.position = new Vector3(x, y, z);
        }

        if (Input.GetKey("right"))
        {
            x = Mathf.Cos(timeCounter) * 4f + 13f;
            z = Mathf.Sin(-timeCounter) * 4f;
            transform.position = new Vector3(x, y, z);
        }

        
    }
}
