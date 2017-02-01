﻿using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

	private GameObject player;
	public int checkNumber;
	public Vector3 checkpoint;
	public Quaternion rotation;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		checkNumber = 0;
		checkpoint = transform.position;
		rotation = transform.rotation;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.K)) {
			print (transform.rotation);
			player.GetComponent<TransforSpaceship> ().acceleration = 0F	;
			//transform.rotation = Quaternion.Euler (0, 0, 0);
			transform.position = checkpoint;
			print (rotation.y);
			transform.rotation = Quaternion.Euler (rotation.x, rotation.y, rotation.z);
			print (transform.rotation);
		}
	}	
}