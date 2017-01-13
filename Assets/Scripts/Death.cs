using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

	public GameObject player;
	public int checkNumber;
	public Vector3 checkpoint;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		checkNumber = 0;
		checkpoint = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.K)) {

			player.GetComponent<TransforSpaceship> ().acceleration = 0F	;
			transform.rotation = Quaternion.Euler (0, 0, 0);
			transform.position = checkpoint;
		}
	}	
}
