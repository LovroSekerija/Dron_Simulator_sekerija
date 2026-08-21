using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody rigidbody;
    public float upForce;
    public float rotation1;
    public float rotation2;
    public float rotation3;
    public float rotation4;
    public float rotation5;
    public float rotation6;
    
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        DroneMovement();
    }

    private void DroneMovement()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rigidbody.AddRelativeForce(0, upForce, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, rotation1, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotation2, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(rotation3, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(rotation4, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, rotation5);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, rotation6);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("1/3, Još malo!!!");
    }
}
