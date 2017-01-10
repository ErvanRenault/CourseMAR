﻿using UnityEngine;
using System.Collections;

public class UpAndDown : MonoBehaviour {

	float speed;
	Vector3 direction;
	float min;
	float max;
	float units = 2.0f;

	// Use this for initialization
	void Start () {
		//Set max to CURRENT position on Y axis, and set min to current minus units (2.0 in this example).
		max = transform.position.y;
		min = transform.position.y - units;

		//Set first direction to be down
		direction = Vector3.down;

	
	}
	
	// Update is called once per frame
	void Update () {
	
		//Change speed depending on direction of object translation.
		if(direction == Vector3.down)
		{
			speed = 10.0f;
		}

		else if(direction == Vector3.up)
		{
			speed = 1.0f;
		}




		//Use transform.Translate to move the current direction and current speed.
		transform.Translate(direction * speed * Time.deltaTime);



		//Change direction if object has reached min or max position on the Y axis (up and down).
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
