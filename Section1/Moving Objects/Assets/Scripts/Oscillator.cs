using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator: MonoBehaviour
{
    public float angle = 90.0f;
    public float speed = 1.5f;
    Quaternion qStart, qEnd;
    private float startTime;
    void Start()
    {
        qStart = Quaternion.AngleAxis(angle, Vector3.forward);
        qEnd = Quaternion.AngleAxis(-angle, Vector3.forward);
    }
    void Update()
    {
        
            startTime += Time.deltaTime;
            transform.rotation = Quaternion.Lerp(qStart, qEnd, (Mathf.Sin(startTime * speed + Mathf.PI / 2) + 1.0f) / 2.0f);
        
    }
}
