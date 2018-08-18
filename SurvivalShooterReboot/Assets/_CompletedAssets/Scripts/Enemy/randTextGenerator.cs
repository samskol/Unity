using UnityEngine;
using System.Collections;

public class randTextGenerator : MonoBehaviour {
	// Use this for initialization
	private int firstNum;
	private int secondNum;
	public string result;
	// set by ref or val?
	void Start () {
		firstNum = Random.Range(0,11);
		secondNum = Random.Range(0,11);

		GetComponent<TextMesh> ().text = firstNum.ToString()+"*"+secondNum.ToString();
		getIntResult ();
		//Debug.Log(getIntResult ());
	}
	int getIntResult(){
		int result = firstNum * secondNum;
		return result;
	}
	public string getStringResult ()
	{
		int a = getIntResult ();
		string x = a.ToString ();
		return x;
	}

	// Update is called once per frame
	void Update () {
	
	}
}
