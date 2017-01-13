using UnityEngine;
using System.Collections;

public class CheckPoints : MonoBehaviour {

	public GameObject player;
	public int checkNumber;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider col) {
		print ("yolo");
		int lastCheck = player.GetComponent<Death> ().checkNumber;
		if (lastCheck < checkNumber) {
			
			player.GetComponent<Death> ().checkNumber = checkNumber;
			player.GetComponent<Death> ().checkpoint = transform.position;
		}
	}
}