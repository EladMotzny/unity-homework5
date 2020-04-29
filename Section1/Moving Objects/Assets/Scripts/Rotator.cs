using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    [Tooltip("Movement speed in meters per second")] [SerializeField] float speed = 1f;
    // Update is called once per frame
    void Update()
    {

        transform.Rotate(new Vector3(0f, speed, 0f));
        
    }
}
