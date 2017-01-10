using UnityEngine;
using System.Collections;

public class TransforSpaceship : MonoBehaviour {

	public float acceleration = 0F;
	public float speedLimit= 30.0F;
	public float boostLimit= 50.0F;
	public float turnSpeed = 50f;


	private Vector3 moveDirection = Vector3.zero;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame

	void Update() {


		if(Input.GetKey(KeyCode.LeftArrow))
			transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);

		if(Input.GetKey(KeyCode.RightArrow))
			transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);

		if (Input.GetKey (KeyCode.Tab)) {
			transform.Translate (Vector3.forward* acceleration* Time.deltaTime);
			if (acceleration < (speedLimit*1.2)) {
				this.acceleration *= 1.2F;	
			}


		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			if (acceleration < 1F) {
				acceleration = 1F;
			}
			transform.Translate (Vector3.forward * acceleration * Time.deltaTime);
			if (acceleration < speedLimit) {
				this.acceleration *= 1.03F;	
			}
		} else {
			transform.Translate(Vector3.forward * acceleration * Time.deltaTime);

		}
		if (acceleration > 1) {
			this.acceleration *= 0.99F;
		}

		if (Input.GetKey(KeyCode.Space))
		{
			this.acceleration *= 0.97F;			
		}

	}

}
