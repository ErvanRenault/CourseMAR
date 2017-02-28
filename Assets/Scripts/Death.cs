using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

	private GameObject player;
	public int checkNumber;
	public Vector3 checkpoint;
	public Quaternion rotation;
	public int currentWaypoint;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		checkNumber = -1;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.K)) {
			player.GetComponent<TransforSpaceship> ().acceleration = 0F	;
			player.GetComponent<WrongDirectionScript> ().currentWaypoint = currentWaypoint;
			transform.position = checkpoint;
			transform.rotation = Quaternion.Euler (rotation.x, rotation.y, rotation.z);
		}

	}	


	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag =="Dead") {
			player.GetComponent<TransforSpaceship> ().acceleration = 0F	;
			player.GetComponent<WrongDirectionScript> ().currentWaypoint = currentWaypoint;
			transform.position = checkpoint;
			transform.rotation = Quaternion.Euler (rotation.x, rotation.y, rotation.z);
		}
	}
}