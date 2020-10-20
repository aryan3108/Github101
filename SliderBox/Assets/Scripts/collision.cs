using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class collision : MonoBehaviour
{
    public movement MovementScript;
    public Rigidbody rb;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            print("we hit an obstacle");
            MovementScript.enabled = false;
            rb.constraints = RigidbodyConstraints.FreezePosition;
        }
    }
}
