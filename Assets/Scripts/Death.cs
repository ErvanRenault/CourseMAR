using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Death : MonoBehaviour {

	private GameObject player;
	public int checkNumber;
	public Vector3 checkpoint;
	public Quaternion rotation;
	public int currentWaypoint;
	public int nbTour;
	public GameObject text;
	public GameObject text2;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		checkNumber = -1;
		nbTour = 0;
		text.SetActive (true);
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