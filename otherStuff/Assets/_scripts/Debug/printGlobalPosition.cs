using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class printGlobalPosition : MonoBehaviour {

	[MenuItem("Debug/print global pos")]
	public static void PrintGlobalPosition()
	{
		if(Selection.activeGameObject != null)
		{
			Debug.Log(Selection.activeGameObject.name + " is at " + " x " + Selection.activeGameObject.transform.position.x +
				" y " + Selection.activeGameObject.transform.position.y + " z " + Selection.activeGameObject.transform.position.z);
		}
	}
}
