using UnityEngine;
using System.Collections;

public class TransforSpaceship : MonoBehaviour {

	public float acceleration = 0F;
	public float speedLimit= 15.0F;
	public float boostLimit= 50.0F;
	public float turnAccel = 5F;
	public float turnSpeed = 100f;
	private Vector3 direction;
	public Rigidbody rb;




	private Vector3 moveDirection = Vector3.zero;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame

	void Update() {

	}
	void FixedUpdate(){

		//perte de vitesse
		if (acceleration > 1) {
			this.acceleration *= 0.99F;
		}
		//brake
		if (Input.GetKey (KeyCode.Space)) {
			this.acceleration *= 0.97F;			
		}

		if (Input.GetKey (KeyCode.Tab)) {
			rb.AddRelativeForce (new Vector3 (0, 0, acceleration));
			if (acceleration < (speedLimit * 1.2)) {
				this.acceleration *= 1.2F;	
			}
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {

			transform.RotateAroundLocal(Vector3.up, -turnAccel* Time.deltaTime);
			rb.AddRelativeForce (new Vector3 (0, 0, acceleration));

		} else {
			//TurnRight
			if (Input.GetKey (KeyCode.RightArrow)) {

				transform.RotateAroundLocal(Vector3.up,  turnAccel* Time.deltaTime);
				rb.AddRelativeForce (new Vector3 (0, 0, acceleration));


			}

			if (Input.GetKey (KeyCode.DownArrow)) {
				if (acceleration < 5F) {
					acceleration = 10F;
				}
				direction = Vector3.back;
				rb.AddRelativeForce (new Vector3 (0, 0, -acceleration));

				if (acceleration < speedLimit) {
					this.acceleration *= 1.03F;	
				}
			} else {
				//forward
				if (Input.GetKey (KeyCode.UpArrow)) {
					if (acceleration < 5F) {
						acceleration = 10F;
					}
					direction = Vector3.forward;
					rb.AddRelativeForce (new Vector3 (0, 0, acceleration));

					if (acceleration < speedLimit) {
						this.acceleration *= 1.03F;	
					}
				}
			}
		}
	}
}
