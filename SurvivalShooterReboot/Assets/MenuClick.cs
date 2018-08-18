using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuClick : MonoBehaviour {

	public void loadScene(string scene){
		SceneManager.LoadScene(scene);
	}
}
