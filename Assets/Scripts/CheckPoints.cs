using UnityEngine;
using System.Collections;

public class CheckPoints : MonoBehaviour {

	private GameObject player;
	public int checkNumber;
	public Quaternion rotation;
	public int currentWaypoint;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider col) {
		int lastCheck = player.GetComponent<Death> ().checkNumber;
		if (lastCheck < checkNumber) {
			player.GetComponent<Death> ().checkNumber = checkNumber;
			player.GetComponent<Death> ().checkpoint = transform.position;
			player.GetComponent<Death> ().rotation = rotation;
			player.GetComponent<Death> ().currentWaypoint = currentWaypoint;
		}
	}
}