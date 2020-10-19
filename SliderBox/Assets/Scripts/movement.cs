using UnityEngine;

public class movement : MonoBehaviour
{
	public Rigidbody rb;
	public float forceforward = 800f, forceSideway = 350f;

	void FixedUpdate()
    {
		rb.AddForce(0, 0, -forceforward * Time.deltaTime);
		if(Input.GetKey("d")|Input.GetKey("right"))
        {
			rb.AddForce(-forceSideway * Time.deltaTime, 0, 0);
        }
		if(Input.GetKey("a")|Input.GetKey("left"))
		{
			rb.AddForce(forceSideway * Time.deltaTime, 0, 0);
		}
		forceforward++;
	}


}
