using UnityEngine;

public class movement : MonoBehaviour
{
	public Rigidbody rb;
	public float forceforward = 1500f, forceSideway = 1200f;

	void FixedUpdate()
    {
		rb.AddForce(0, 0, -forceforward * Time.deltaTime);
		if(Input.GetKey("d"))
        {
			rb.AddForce(-forceSideway * Time.deltaTime, 0, 0);
        }
		if (Input.GetKey("a"))
		{
			rb.AddForce(forceSideway * Time.deltaTime, 0, 0);
		}
	}


}
