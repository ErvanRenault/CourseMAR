using UnityEngine;
using System.Collections;
using UnityEngine.UI;

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
		if (lastCheck < checkNumber || checkNumber == 0) {
			player.GetComponent<Death> ().checkNumber = checkNumber;
			player.GetComponent<Death> ().checkpoint = transform.position;
			player.GetComponent<Death> ().rotation = rotation;
			player.GetComponent<Death> ().currentWaypoint = currentWaypoint;
		}

		if (checkNumber == 0 && lastCheck == 5) {
			
			player.GetComponent<Death> ().nbTour++;
			string s = "Tour : " + player.GetComponent<Death> ().nbTour + "/3";
			player.GetComponent<Death> ().text.GetComponent<Text> ().text = s;

			if (player.GetComponent<Death> ().nbTour == 3) {
				player.GetComponent<Death> ().text2.SetActive(true);
			}

		}
	}
}