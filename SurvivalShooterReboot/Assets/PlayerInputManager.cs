using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.Windows;
using System.Collections;
using System.Collections.Generic;
//using UnityEngine.Windows.Speech;
using CompleteProject;

public class PlayerInputManager : MonoBehaviour {

	// Use this for initialization
	Text text2;
	string texting;
	int tempNum;

	public randTextGenerator zomBunny;
	public randTextGenerator zomBear;
	public EnemyManagerMain enemyList;
	private bool instantiation=false;
	//private ConfidenceLevel Low;
	//private DictationTopicConstraint dictation;
	//private DictationRecognizer m_DictationRecognizer;


	[SerializeField]
	private Text m_Hypotheses;

	[SerializeField]
	private Text m_Recognitions;


	void Awake(){
		text2 = GetComponent<Text> ();
		enemyList = GameObject.Find("EnemyManagerMain").GetComponent<EnemyManagerMain>();
	}

	/*private void DictationRecognizer_DictationResult(string text, ConfidenceLevel confidence)
	{
		Debug.LogFormat("Dictation result: {0}", text);
		m_Recognitions.text += text + "\n";
	}
	private void DictationRecognizer_DictationHypothesis(string text)
	{
		Debug.LogFormat("Dictation hypothesis: {0}", text);
		m_Hypotheses.text += text;
	}

	private void DictationRecognizer_DictationComplete(DictationCompletionCause cause)
	{
		if (cause != DictationCompletionCause.Complete)
			Debug.LogErrorFormat("Dictation completed unsuccessfully: {0}.", cause);
	}

	private void DictationRecognizer_DictationError(string error, int hresult)
	{
		Debug.LogErrorFormat("Dictation error: {0}; HResult = {1}.", error, hresult);
	}*/

	void Start(){
		text2.text = "";
		/*Low = ConfidenceLevel.Medium;
		dictation = DictationTopicConstraint.Dictation;
		m_DictationRecognizer = new DictationRecognizer(Low, dictation);

		m_DictationRecognizer.DictationResult += DictationRecognizer_DictationResult;

		m_DictationRecognizer.DictationHypothesis += DictationRecognizer_DictationHypothesis;

		m_DictationRecognizer.DictationComplete += DictationRecognizer_DictationComplete;

		m_DictationRecognizer.DictationError += DictationRecognizer_DictationError;

		m_DictationRecognizer.Start();*/

		/*m_DictationRecognizer.DictationResult += (text, confidence) =>
		{
			Debug.LogFormat("Dictation result: {0}", text);
			m_Recognitions.text += text + "\n";
		};

		m_DictationRecognizer.DictationHypothesis += (text) =>
		{
			Debug.LogFormat("Dictation hypothesis: {0}", text);
			m_Hypotheses.text += text;
		};

		m_DictationRecognizer.DictationComplete += (completionCause) =>
		{
			if (completionCause != DictationCompletionCause.Complete)
				Debug.LogErrorFormat("Dictation completed unsuccessfully: {0}.", completionCause);
		};

		m_DictationRecognizer.DictationError += (error, hresult) =>
		{
			Debug.LogErrorFormat("Dictation error: {0}; HResult = {1}.", error, hresult);
		};

		m_DictationRecognizer.Start();*/
	}


	
	// Update is called once per frame
	void Update () {
		instantiation = enemyList.startBool;
		//Debug.Log (instantiation);
		if (Input.inputString != null) {
			if (int.TryParse (Input.inputString, out tempNum)) {
				text2.text = text2.text + Input.inputString;
			}
			if (Input.GetButtonDown ("Submit")) {
				if (instantiation == true) {
					checkAnswer ();
				}
				text2.text = "";
			}
		}

		//text2.text = text2.text+m_Recognitions.ToString();
		//Debug.Log (m_Recognitions.ToString ());

	}
	void checkAnswer(){
		foreach(GameObject bunny in GameObject.FindGameObjectsWithTag("Enemy")){ 
			if (text2.text == bunny.GetComponentInChildren<randTextGenerator> ().getStringResult()) {
				//Debug.Log ("hit");
				bunny.GetComponentInChildren<EnemyHealth> ().TakeDamage (1000000,  bunny.transform.position);
			}
		}
	}
}