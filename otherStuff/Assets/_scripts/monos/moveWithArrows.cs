using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class moveWithArrows : MonoBehaviour {

	// Use this for initialization
	[HideInInspector]
	public enemyData data;
	private float timer;
	void Start() {
		gameObject.name = data.name;
		timer = data.moveStep;
		gameObject.GetComponent<Renderer>().material.color = data.color;
	}

	// Update is called once per frame
	void Update() {
		timer -= Time.deltaTime;
		if (timer <= 0)
		{
			Move();
			timer += data.moveStep;
		}
	}

	private void Move()
	{
		if (Input.GetButtonDown("Horizontal"))
		{
			if (Input.GetAxis("Horizontal") > 0)
			{
				transform.position += Vector3.right;
			}
			else
				transform.position += Vector3.left;
		}


		if (Input.GetButtonDown("Vertical"))
		{
			if (Input.GetAxis("Vertical") > 0)
			{
				transform.position += Vector3.up;
			}
			else
				transform.position += Vector3.down;
		}

	}
}
