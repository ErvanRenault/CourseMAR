using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	public void LoadSceneByIndex(int sceneIndex){
		SceneManager.LoadScene (sceneIndex);
	}

}
