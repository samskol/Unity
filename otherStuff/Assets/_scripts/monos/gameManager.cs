using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour {

	// Use this for initialization
	public enemyData[] levelData;

	public moveWithArrows enemyMove;
	[Range(1,4)]
	public int range;
	void Awake () {

		if (range > levelData.Length)
		{
			enemyMove.data = levelData[levelData.Length - 1];
		}

		else
			enemyMove.data = levelData[range-1];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
