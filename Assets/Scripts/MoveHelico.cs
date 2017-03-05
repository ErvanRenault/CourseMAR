using UnityEngine;
using System.Collections;

public class MoveHelico : MonoBehaviour {

	public GameObject vaisseau;
	private Vector3 target;
	private float step;
	// Use this for initialization
	void Start () {
		step = 100f * Time.deltaTime;
		}
	
	// Update is called once per frame
	void Update () {
		target = new Vector3(vaisseau.transform.position.x,transform.position.y,vaisseau.transform.position.z);
		transform.position = Vector3.MoveTowards (transform.position, target, step);
	} 

}