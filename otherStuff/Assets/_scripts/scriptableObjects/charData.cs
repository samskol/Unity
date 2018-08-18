using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[CreateAssetMenu(menuName = "soAssets/char data")]
public class charData : ScriptableObject {

	public string charModel;

	[Serializable]
	public struct ThrowData
	{
		public string anim;
		[Range(0,100)]
		public float chance;
		[Range(0, 10)]
		public int difficulty;
		[Range(0, 100)]
		public float semiVal;
		[Range(0, 100)]
		public float aimVal;
		[Range(0, 100)]
		public float miss;
		public ThrowData(string animc, float chancec,int difficultyc, float semibvalc, float aimbvalc, float bmissc)
		{
			anim = animc;
			chance = chancec;
			difficulty = difficultyc;
			semiVal = semibvalc;
			aimVal = aimbvalc;
			miss = bmissc;
		}
	}
	public List<ThrowData> throwData; // associated percentage throwing 
}
