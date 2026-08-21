using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour
{
    public GameObject CAM1;
    public GameObject CAM2;

    

    void Update()
    {
        ChangeCamera();
    }

    private void ChangeCameraPosition()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))

        {
            transform.position = new Vector3(0, 0, 0.375f);
            //transform.rotation = new Quaternion(0, 0, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            transform.position = new Vector3(0, (float)7.5, -2);
            //transform.rotation = new Quaternion(10, 0, 0, 0);
        }
    }

    void ChangeCamera()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))

        {
            CAM1.SetActive(true);
            CAM2.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            CAM2.SetActive(true);
            CAM1.SetActive(false);
        }

    }
}
