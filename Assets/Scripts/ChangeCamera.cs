using UnityEngine;
using System.Collections;

public class ChangeCamera : MonoBehaviour {

	public Camera cameraFirstPerson;
	public Camera cameraSemiPerson;
	public Camera cameraThirdPerson;
	public Camera cameraHelico;

	public int cameraNum;

	void Start()
	{
		cameraFirstPerson.enabled = true;
		cameraThirdPerson.enabled = false;
		cameraSemiPerson.enabled = false;
		cameraHelico.enabled = false;
		cameraNum = 0;

	}
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.A))
		{
			switch (cameraNum) {
			case 0: 
				cameraFirstPerson.enabled = false;
				cameraSemiPerson.enabled = true;

				cameraNum =(cameraNum + 1) % 4;
				break;
			case 1: 
				cameraThirdPerson.enabled = true;
				cameraSemiPerson.enabled = false;
				cameraNum =(cameraNum + 1)  % 4;
				break;
			case 2: 
				cameraThirdPerson.enabled = false;
				cameraHelico.enabled = true;
				cameraNum =(cameraNum + 1 ) % 4;
				break;
			case 3: 
				cameraFirstPerson.enabled = true;
				cameraHelico.enabled = false;
				cameraNum =(cameraNum + 1)  % 4;
				break;
			}
		}
	}
}
