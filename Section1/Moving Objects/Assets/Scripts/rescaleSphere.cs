﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rescaleSphere : MonoBehaviour
{

    

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()

    {
        Vector3 vec = new Vector3(Mathf.Sin(Time.time * 2), Mathf.Sin(Time.time * 2), Mathf.Sin(Time.time * 2));

        transform.localScale = vec;
    }
}
