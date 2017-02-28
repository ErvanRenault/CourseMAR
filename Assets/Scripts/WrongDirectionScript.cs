using UnityEngine;
using System.Collections;

public class WrongDirectionScript : MonoBehaviour {
	public GameObject[] waypoints;
	public int currentWaypoint = 0;
	public int lastWaypoint = -1;
	private GameObject currWaypoint;
	private GameObject nextWaypoint;
	private Vector3 trackDir;
	private float distance;
	private float distanceToNext;
	private Vector3 carHeading;
	public bool wrong;
	public GameObject text;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (lastWaypoint != currentWaypoint) {
			currWaypoint = waypoints [currentWaypoint%waypoints.Length];
			nextWaypoint = waypoints [(currentWaypoint + 1)%waypoints.Length];
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
			text.SetActive(true);
		} else {
			text.SetActive(false);
		}
	}
}
