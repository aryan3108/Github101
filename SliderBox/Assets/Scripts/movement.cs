using UnityEngine;

public class movement : MonoBehaviour
{
	public Rigidbody rb;
	public float forceforward = 800f, forceSideway = 350f;

	void FixedUpdate()
    {
		rb.AddForce(0, 0, -forceforward * Time.deltaTime);
		if(Input.GetKeyA)
		{
			rb.AddForce(forceSideway * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		if(Input.GetKeyD)
        {
			rb.AddForce(-forceSideway * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }	
	}
}
