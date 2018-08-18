using UnityEngine;
using System.Collections;

public class lookAtCamera : MonoBehaviour {
	private Camera camera;
	// Use this for initialization
	void Start () {
		camera = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.LookAt (2*gameObject.transform.position-camera.transform.position);
	}
}
