using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

public class movement : MonoBehaviour
{
	public Rigidbody rb;
	public float forceforward = 800f, forceSideway = 350f;

	void FixedUpdate()
    {
		rb.AddForce(0, 0, -forceforward * Time.deltaTime);
		if(Input.GetKey("a"))
		{
			rb.AddForce(forceSideway * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		if(Input.GetKey("d"))
        {
			rb.AddForce(-forceSideway * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
		
	}


}
