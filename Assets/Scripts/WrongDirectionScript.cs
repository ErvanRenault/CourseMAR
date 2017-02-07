using UnityEngine;
using System.Collections;

public class WrongDirectionScript : MonoBehaviour {
	public GameObject[] waypoints;
	public int currentWaypoint;
	public int lastWaypoint;
	public GameObject currWaypoint;
	public GameObject nextWaypoint;
	public Vector3 trackDir;
	public float distance;
	public float distanceToNext;
	public Vector3 carHeading;
	public bool wrong;

	// Use this for initialization
	void Start () {
		currentWaypoint = 0;
		lastWaypoint = -1;
	}
	
	// Update is called once per frame
	void Update () {
		if (lastWaypoint != currentWaypoint) {
			currWaypoint = waypoints [currentWaypoint];
			nextWaypoint = waypoints [currentWaypoint + 1];
			lastWaypoint = currentWaypoint;
		}
		trackDir = nextWaypoint.transform.position - currWaypoint.transform.position;
		Vector3 carHeading = transform.position - currWaypoint.transform.position;
		distance = Vector3.Dot(carHeading, trackDir);
		Vector3 carHeading2 = transform.position - nextWaypoint.transform.position;
		distanceToNext = Vector3.Dot (carHeading2, trackDir); 

		if (distanceToNext > -50)
			currentWaypoint++;

		if (Vector3.Dot (transform.forward, trackDir) < 0F) {
			wrong = true;
		} else {
			wrong = false;
		}
	}
}
