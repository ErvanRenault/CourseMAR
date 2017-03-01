using UnityEngine;
using System.Collections;

public class MoveHelico : MonoBehaviour {

	public GameObject vaisseau;
	private Vector3 target;
	private float step;
	private float previousZ;
	// Use this for initialization
	void Start () {
		step = 100f * Time.deltaTime;
		previousZ = vaisseau.transform.position.z;
		}
	
	// Update is called once per frame
	void Update () {
		target = new Vector3(vaisseau.transform.position.x,transform.position.y,vaisseau.transform.position.z);
		/*if (previousZ < vaisseau.transform.position.z - 2f || previousZ > vaisseau.transform.position.z + 2f) {
			var rotation = Quaternion.LookRotation (target);
			transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime);
			//transform.LookAt (target);
			previousZ = vaisseau.transform.position.z;
		} else {
		*/	transform.position = Vector3.MoveTowards (transform.position, target, step);
		//}
		//print (vaisseau.transform.position.z);
		//print ("previous Z = " + transform.position.z);
		
	} 

}