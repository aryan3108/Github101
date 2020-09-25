using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
	private float speed = 2.0f;
	public float velocity = 1500f;
	public GameObject character;
	void FixedUpdate()
    {
		character.GetComponent<Rigidbody>().AddForce(0, 0, velocity * Time.deltaTime);
    }
	void Update()
	{

		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position += Vector3.left * speed * Time.deltaTime;
		}
		
	}

}
