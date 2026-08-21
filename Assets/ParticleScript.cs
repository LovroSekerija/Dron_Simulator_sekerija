using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour
{
    ParticleSystem partSys;

    public GameObject dronePlayer;

    void Awake()
    {
        partSys = GetComponent<ParticleSystem>();
    }

    void OnParticleCollision(GameObject other)
    {
        Debug.Log("Collided");  
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided");
    }


}
