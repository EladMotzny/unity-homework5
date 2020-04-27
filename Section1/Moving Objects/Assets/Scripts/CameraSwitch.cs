using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{

    public Camera[] cams;

    public void camPendulum()
    {
        cams[0].enabled = true;
        cams[1].enabled = false;
        cams[2].enabled = false;
        cams[3].enabled = false;
    }
    public void camRotate()
    {
        cams[0].enabled = false;
        cams[1].enabled = true;
        cams[2].enabled = false;
        cams[3].enabled = false;
    }

    public void camCircle()
    {
        cams[0].enabled = false;
        cams[1].enabled = false;
        cams[2].enabled = true;
        cams[3].enabled = false;
    }

    public void camRescale()
    {
        cams[0].enabled = false;
        cams[1].enabled = false;
        cams[2].enabled = false;
        cams[3].enabled = true;
    }



}
