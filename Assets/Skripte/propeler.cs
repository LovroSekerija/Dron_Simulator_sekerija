using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propeler : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Rotate(0, 25, 0); 
        }
    }
}
