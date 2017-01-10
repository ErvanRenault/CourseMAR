using UnityEngine;
using System.Collections;

public class UpandDownCollision : MonoBehaviour {

	public Vector3 teleportPoint;
	public Rigidbody rb;

	float speed;
	Vector3 direction;
	float min;
	float max;
	float units = 2.0f;


	void Start() {
		rb = GetComponent<Rigidbody>();

		//Set max to CURRENT position on Y axis, and set min to current minus units (2.0 in this example).
		max = transform.position.y;
		min = transform.position.y - units;

		//Set first direction to be down
		direction = Vector3.down;
	}


	void FixedUpdate() {

		if(direction == Vector3.down)
		{
			speed = 10.0f;
		}

		else if(direction == Vector3.up)
		{
			speed = 1.0f;
		}


		rb.MovePosition(direction * speed * Time.deltaTime);

		if(transform.position.y >= max)
		{
			direction = Vector3.down;
		}

		if(transform.position.y <= min)
		{
			direction = Vector3.up;    
		}
	}
}
