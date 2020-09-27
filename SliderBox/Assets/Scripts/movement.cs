using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
	public Rigidbody rb;
	public float forceforward = 1500f, forceSideway = 1200f;

	void FixedUpdate()
    {
		rb.AddForce(0, 0, -forceforward * Time.deltaTime);
    }


}
